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
    public class ChatMessageRepo : Repository<ChatMessage>, IChatMessageRepo
    {
        public ChatMessageRepo(DataContext context)
            :base(context)
        {

        }
        public DataContext DataContext
        {
            get
            {
                return Context as DataContext;
            }
        }

        public IEnumerable<ChatMessage> GetAllConversation(string sender, string reciever)
        {
            return DataContext.ChatMessages.Where(x => x.UserNameSender == sender && x.UserNameReciever == reciever || x.UserNameSender == reciever && x.UserNameReciever == sender);
        }


        public  void SetIsReadOfCurrentUser(string currentUser, string reciever)
        {
            var msgs = DataContext.ChatMessages.Where(x => x.UserNameSender == reciever && x.UserNameReciever == currentUser);
            foreach (var msg in msgs)
            {
                msg.IsRead = true;
                DataContext.Entry(msg).State = System.Data.Entity.EntityState.Modified;
            }
        }


        public bool CurrentUserHasNewMessage(string _currentUser, string _reciever)
        {
            var msgs = DataContext.ChatMessages.Where(x => x.UserNameSender == _reciever && x.UserNameReciever == _currentUser && x.IsRead == false);
            if (msgs.Count() > 0)
            {
                return true;
            }
            return false;
        }


        

        public IEnumerable<ChatMessage> GetAll(bool isNotified, string _currentUser)
        {
            return DataContext.ChatMessages.Where(x => x.UserNameReciever == _currentUser && x.IsNotified == isNotified).ToList();
            
        }





        public ChatMessage GetMessage(string userName, bool isRead)
        {
            return DataContext.ChatMessages.Where(x => x.UserNameReciever == userName && x.IsRead == isRead).FirstOrDefault();
        }


        public IEnumerable<ChatMessage> GetAll(string userName, bool isRead)
        {
            return DataContext.ChatMessages.Where(x => x.UserNameReciever == userName && x.IsRead == isRead).ToList();
        }


        public IEnumerable<ChatMessage> GetAllConversation(string sender, string currentUser, bool isRead)
        {
            return DataContext.ChatMessages.Where(x => x.UserNameSender == sender && x.UserNameReciever == currentUser && x.IsRead == false);
        }
    }
}
