using POS.Queries.Core.Domain;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Queries.Core.IRepositories
{
    public interface IChatMessageRepo : IRepository<ChatMessage>
    {


        IEnumerable<ChatMessage> GetAllConversation(string sender, string reciever);

        /// <summary>
        /// Set IsRead to true
        /// </summary>
        /// <param name="_sender">current user</param>
        /// <param name="_reciever">user where the message from</param>
        void SetIsReadOfCurrentUser(string _sender, string _reciever);

        bool CurrentUserHasNewMessage(string _currentUser, string _reciever);

        IEnumerable<ChatMessage> GetAll(bool isNotified, string _currentUser);



        ChatMessage GetMessage(string userName, bool isRead);


        IEnumerable<ChatMessage> GetAll(string userName, bool isRead);

        /// <summary>
        /// Get Conversations
        /// </summary>
        /// <param name="sender">Person to Talk with</param>
        /// <param name="currentUser">Current Login User</param>
        /// <param name="isRead">Read or Unread Message</param>
        /// <returns></returns>
        IEnumerable<ChatMessage> GetAllConversation(string sender, string currentUser, bool isRead);
    }
}
