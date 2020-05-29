using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Logic.Models
{
    public class UserListModel
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string Role { get; set; }
       
    }

    public class UserModel
    {
        public int UserID { get; set; }
        public string UserName { get; set; }

    }
    public class AddEditUserModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public bool IsOnline { get; set; }
        public int RoleID { get; set; }
    }
    public class UserChatListModel
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public bool IsOnline { get; set; }

        public int UnReadMessageCount { get; set; }
    }
}
