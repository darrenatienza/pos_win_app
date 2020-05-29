using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Queries.Core.Domain
{
    public class ProductLog
    {
        public ProductLog()
        {

        }

        public int ProductLogID { get; set; }
        public DateTime CreateTimeStamp { get; set; }
        public virtual Product Product { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public string Action { get; set; }
        public string Remarks { get; set; }
    }
}
