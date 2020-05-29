using POS.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Logic.ILogics
{
    public interface IUserLogic
    {

        void LoginUser(string userName, string password);

        List<UserListModel> GetUserList(string criteria);

        void Delete(int userID);

        UserModel GetUser(int _userID);

        void Add(AddEditUserModel model);

        void Edit(int _userID, AddEditUserModel model);

        void SetOnlineStatus(string userName, bool isOnline);

        List<UserChatListModel> GetUserChatList(string userName);
    }
}
