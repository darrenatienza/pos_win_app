using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Logic.Models
{
    public class ProductModel
    {
        public int ProductID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }


        public int Quantity { get; set; }

        public string Remarks { get; set; }

        public int Limit { get; set; }

        public double? Price { get; set; }

        public int SupplierID { get; set; }

        public string SupplierName { get; set; }
    }
}
