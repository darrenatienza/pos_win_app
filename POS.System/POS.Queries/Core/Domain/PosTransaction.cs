using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Queries.Core.Domain
{
    public class PosTransaction
    {
        public PosTransaction()
        {
            PosTransactionProducts = new HashSet<PosTransactionProduct>();
            
        }

        public int POSTransactionID { get; set; }
        public virtual Member Member { get; set; }
        
        public int MemberID { get; set; }
        public DateTime CreateTimeStamp { get; set; }
        public string TransactionCode { get; set; }
        public double? AmountTender { get; set; }
        public bool IsComplete { get; set; }
        public virtual User User { get; set; }
        public int? UserID { get; set; }
        public double? Total { get; set; }
        
        public ICollection<PosTransactionProduct> PosTransactionProducts { get; set; }
       
    }
}
