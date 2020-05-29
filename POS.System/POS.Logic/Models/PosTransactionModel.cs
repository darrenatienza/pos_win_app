using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Logic.Models
{
    public class PosTransactionModel
    {
        public PosTransactionModel() { }
        public int PosTransactionID { get; set; }

        public string TransactionCode { get; set; }

    }
    public class PosTransactionSaleSummaryModel
    {
        public double SaleToday { get; set; }
        public double SaleWeek { get; set; }
        public double SaleMonth { get; set; }
    }
    public class PreviousTransactionListModel
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public string TransactionCode { get; set; }
        public int Quantity { get; set; }
        public double AmountTendered { get; set; }
        public double Total { get; set; }
    }
    public class PreviousTransactionListModel2
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public string TransactionCode { get; set; }
        public int Quantity { get; set; }
        public double AmountTendered { get; set; }
        public double Total { get; set; }
    }
    public class TransactionProductListModel
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public string TransactionCode { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public double SubTotal { get; set; }
    }

    public class TransactionProductModel
    {
        public int ID { get; set; }
        public string TransactionCode { get; set; }
        public string ProductName { get; set; }
        public int AvailableQuantity { get; set; }
        public double Total { get; set; }

        public double? Price { get; set; }
        public int PurchaseQuantity { get; set; }
    }
    public class UpdateQuantityModel
    {
        public int AvailableQuantity { get; set; }
        public double TotalAmount { get; set; }
    }
    public class PosTransactionDetail
    {
        public string DateTimePurchase { get; set; }
        public string MemberName { get; set; }
        public string Quantity { get; set;}
        public string AmountTendered { get; set; }
        public string Change { get; set; }
        public string Cashier { get; set; }
    }
    public class PosTransactionProductModel
    {
        public double? UnitPrice;
        public int ID { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public double SubTotal { get; set; }
    }
    
    
}
