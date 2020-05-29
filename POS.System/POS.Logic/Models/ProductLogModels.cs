﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Logic.Models
{
    public class ProductLogModel
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public string ProductName { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public string Action { get; set; }
        public string Remarks { get; set; }
    }
}
