using Helpers;
using POS.Logic.ILogics;
using POS.Logic.Models;
using POS.Queries.Core.Domain;
using POS.Queries.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Logic.Logics
{
    public class UserLogic : IUserLogic
    {
        public UserLogic() { }


        public void LoginUser(string userName, string password)
        {
            var crypto = new SimpleCrypto.PBKDF2();
            using (var uow = new UnitOfWork(new DataContext()))
                {
                    User user = uow.Users.GetUser(userName);
                    if (user != null)
                    {
                        if (user.Password != crypto.Compute(password, user.PasswordSalt))
                        {
                            throw new ApplicationException("Invalid Password!");
                        }
                        else
                        {
                            CurrentUser.UserID = user.UserID;
                            CurrentUser.Name = user.UserName;
                            CurrentUser.Roles = user.Roles.Select(x => x.Description).ToList();
                            user.IsOnline = true;
                            uow.Users.Edit(user);
                            uow.Complete();
                        }
                    }
                    else
                    {
                        throw new ApplicationException("Invalid User Name!");
                    }
                }
        }


        public List<UserListModel> GetUserList(string criteria)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var models = new List<UserListModel>();
                var users = uow.Users.GetUsers(criteria);
                foreach (var user in users)
                {
                    var model = new UserListModel();
                    model.UserID = user.UserID;
                    model.UserName = user.UserName;
                    model.FullName = user.FirstName + " " + user.LastName;
                    // user id 1 for admin user is administrator
                    if (model.UserID == 1)
                    {
                        model.Role = "Administrator";
                    }
                    else
                    {
                        model.Role = user.Roles.First().Description;
                    }
                    
                    models.Add(model);
                }
                return models;
            }
        }


        public void Delete(int userID)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var user = uow.Users.Get(userID);
                uow.Users.Remove(user);
                uow.Complete();
            }
        }


        public UserModel GetUser(int _userID)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var model = new UserModel();
                var user = uow.Users.Get(_userID);
                model.UserID = user.UserID;
                model.UserName = user.UserName;
                return model;
            }
        }


        public void Add(AddEditUserModel model)
        {
            var crypto = new SimpleCrypto.PBKDF2();
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var user = new User();
                user.FirstName = model.FirstName;
                user.MiddleName = model.MiddleName;
                user.LastName = model.LastName;
                var encrypPass = crypto.Compute(model.Password);
                user.Password = encrypPass;
                user.PasswordSalt = crypto.Salt;
                user.Roles.Add(uow.Roles.Get(model.RoleID));
                user.UserName = model.UserName;
                uow.Users.Add(user);
                uow.Complete();
            }
           
        }

        public void Edit(int _userID, AddEditUserModel model)
        {
            var crypto = new SimpleCrypto.PBKDF2();
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var user = uow.Users.GetUser(_userID);
                user.FirstName = model.FirstName;
                user.MiddleName = model.MiddleName;
                user.LastName = model.LastName;
                var encrypPass = crypto.Compute(model.Password);
                user.Password = encrypPass;
                user.PasswordSalt = crypto.Salt;
                user.Roles.Clear();
                user.Roles.Add(uow.Roles.Get(model.RoleID));
                user.UserName = model.UserName;
                uow.Users.Edit(user);
                uow.Complete();
            }
        }


        public void SetOnlineStatus(string userName, bool isOnline)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var user = uow.Users.GetUser(userName);
                if (user != null)
                {
                    user.IsOnline = false;
                    uow.Users.Edit(user);
                    uow.Complete();
                }
            }
        }


        public List<UserChatListModel> GetUserChatList(string currentUser)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var models = new List<UserChatListModel>();
                var users = uow.Users.GetAllNotCurrentUser(currentUser);
                foreach (var item in users)
                {
                    var model = new UserChatListModel();
                    model.IsOnline = item.IsOnline;
                    model.UserID = item.UserID;
                    model.UserName = item.UserName;
                    model.UnReadMessageCount = uow.ChatMessages.GetAllConversation(item.UserName,currentUser,false).Count();
                    models.Add(model);
                }
                return models;
                
            }
        }
    }
}
