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
    public class ChatLogic : IChatLogic
    {
        public ChatLogic() { }




        public bool HasUnreadMessages(string userName)
        {
            bool hasUnreadMessage = false;
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var msg = uow.ChatMessages.GetMessage(userName, false);
                if (msg != null)
                {
                    hasUnreadMessage = true;
                }
            }
            return hasUnreadMessage;
        }
    }
}
