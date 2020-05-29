using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Queries.Core.Domain
{
    public class PosTransactionProduct
    {
        public PosTransactionProduct() { }
        public int PosTransactionProductID { get; set; }
        public virtual PosTransaction PosTransaction { get; set; }
        public int PosTransactionID { get; set; }
        public virtual Product Product { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
    }
}
