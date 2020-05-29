using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Queries.Core.Domain
{
    public class ChatMessage
    {
        public ChatMessage() { }
        public int ChatMessageID { get; set; }
        public string UserNameSender { get; set; } 
        public string UserNameReciever { get; set; }
        public string Message { get; set; }
        public bool IsRead { get; set; }
        public DateTime CreateDateTime { get; set; }
        public bool IsNotified { get; set; }
    }
    
}
