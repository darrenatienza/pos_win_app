using POS.Queries.Core.Domain;
using POS.Queries.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace POS.Queries.Persistence.Repositories
{
    public class UserRepository : Repository<User>, IUserRepo
    {
        public UserRepository(DataContext context)
            : base(context)
        {
        }
        public IEnumerable<User> GetUsers()
        {
            return DataContext.Users.ToList();
        }
        public DataContext DataContext
        {
            get
            {
                return Context as DataContext;
            }
        }


        public User GetUser(string userName)
        {

            return DataContext.Users.Include(u => u.Roles).FirstOrDefault(user => user.UserName == userName);
        }


        public void RemoveUsersPermissions(int userID)
        {

            var a = DataContext.Users.Include(i => i.Roles).Where(u => u.UserID == userID).FirstOrDefault<User>();
            var p = a.Roles.ToList();
            p.ForEach(pe => a.Roles.Remove(pe));
        }


        public User GetUser(int userID)
        {
            return DataContext.Users.Include(i => i.Roles).Where(u => u.UserID == userID).FirstOrDefault<User>();
        }


        public IEnumerable<User> GetUsers(string criteria)
        {
            return DataContext.Users.Include(u => u.Roles)
                .Where(u => u.UserName.Contains(criteria) || u.FirstName.Contains(criteria)).ToList();
        }





        public IEnumerable<User> GetAllNotCurrentUser(string currentUser)
        {
            return DataContext.Users.Include(u => u.Roles)
                 .Where(u => u.UserName != currentUser).ToList();
        }
    }

   
}
