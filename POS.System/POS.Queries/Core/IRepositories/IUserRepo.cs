using POS.Queries.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Queries.Core.IRepositories
{
    public interface IUserRepo : IRepository<User>
    {
        IEnumerable<User> GetUsers();

        User GetUser(string userName);

        User GetUser(int userID);
        void RemoveUsersPermissions(int userID);

        IEnumerable<User> GetUsers(string criteria);

        IEnumerable<User> GetAllNotCurrentUser(string currentUser);
    }
}
