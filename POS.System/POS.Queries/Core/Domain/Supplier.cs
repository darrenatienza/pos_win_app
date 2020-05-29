using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Queries.Core.Domain
{
    public class Supplier
    {
        public Supplier() { }
        public int SupplierID { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string Remarks { get; set; }
        public DateTime CreateTimeStamp { get; set; }

    }
}
