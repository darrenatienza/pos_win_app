using Helpers;
using POS.Logic.ILogics;
using POS.Logic.Models;
using POS.Queries.Core.Domain;
using POS.Queries.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Logic.Logics
{
    public class PosTransactionLogic : IPosTransactionLogic
    {
        public PosTransactionLogic() { }



        public double GetTotal(int _posTransanctionID)
        {
            double total = 0;
            using (var uow = new UnitOfWork(new DataContext()))
            {

                var objs = uow.PosTransactionProducts.GetAllBy(_posTransanctionID)
                .GroupBy(x => x.ProductID).Select(x => new { Total = x.Sum(y => y.Product.Price * y.Quantity) });
                total = objs.Sum(x => x.Total).Value;
            }
            return total;
        }


        public void DeleteTransactionProduct(int posTransactionProductID)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var productQuantity = 0;
                var productID = 0;
                var posTransactionProduct = uow.PosTransactionProducts.Get(posTransactionProductID);
                productQuantity = posTransactionProduct.Quantity;
                productID = posTransactionProduct.ProductID;
                uow.PosTransactionProducts.Remove(posTransactionProduct);
                var product = uow.Products.Get(productID);
                product.Quantity += productQuantity;
                uow.Products.Edit(product);
                uow.Complete();
            }
        }


        public void AddTransactionProduct(string productName, int posTransactionID, int quantity)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var product = uow.Products.GetExact(productName);
                // if one product found, add it to transactions
                if (product != null)
                {
                    // subtract the quantity purchase to current stock quantity of the item
                    var quantityResult = product.Quantity - quantity;

                    if (quantityResult < product.Limit)
                    {
                        throw new ApplicationException("Quantity purchase exceed to the product limit!");
                    }
                    //Todo: Compute for total
                    
                    var posTransactionProduct = new PosTransactionProduct();
                    posTransactionProduct.PosTransactionID = posTransactionID;
                    posTransactionProduct.ProductID = product.ProductID;
                    posTransactionProduct.Quantity = quantity;
                    uow.PosTransactionProducts.Add(posTransactionProduct);
                    // deduct quantity
                    product.Quantity -= quantity;
                    uow.Products.Edit(product);
                    uow.Complete();
                }

            }
        }


        public void CompletePosTransaction(int _postTransactionID, double amountTendered, double total)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var posTransaction = uow.PosTransaction.Get(_postTransactionID);
                posTransaction.AmountTender = amountTendered;
                posTransaction.Total = total;
                posTransaction.IsComplete = true;
                uow.PosTransaction.Edit(posTransaction);
                uow.Complete();
            }
        }


        public int GenerateNewTransactionID()
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var postTransaction = new PosTransaction();
                postTransaction.CreateTimeStamp = DateTime.Now;
                postTransaction.TransactionCode = Utils.RandomNumbers(5);
                postTransaction.AmountTender = 0;
                postTransaction.UserID = CurrentUser.UserID;
                uow.PosTransaction.Add(postTransaction);
                uow.Complete();
                return postTransaction.POSTransactionID;
            }
        }


        public int GetPreviousPosTransactionID()
        {
            int id = 0;
            using (var uow = new UnitOfWork(new DataContext()))
            {
                // get incomplete pos transactions on current login user
                var posTransaction = uow.PosTransaction.Get(CurrentUser.UserID, false);
                id = posTransaction.POSTransactionID;
            }
            return id;
        }


        public PosTransactionModel GenerateNewTransaction()
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var posTransaction = new PosTransaction();
                posTransaction.CreateTimeStamp = DateTime.Now;
                posTransaction.TransactionCode = Utils.RandomNumbers(5);
                posTransaction.MemberID = 1; // member always walk in as default;
                posTransaction.AmountTender = 0;
                posTransaction.UserID = CurrentUser.UserID;
                uow.PosTransaction.Add(posTransaction);
                uow.Complete();

                return new PosTransactionModel { PosTransactionID = posTransaction.POSTransactionID, TransactionCode = posTransaction.TransactionCode };
            }
        }


        public PosTransactionModel GetPreviousPosTransaction()
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var posTransaction = uow.PosTransaction.Get(CurrentUser.UserID, false);
                if (posTransaction != null)
                {
                    return new PosTransactionModel { PosTransactionID = posTransaction.POSTransactionID, TransactionCode = posTransaction.TransactionCode };
                }
                // no transactions found
                return null;
            }
        }


        public PosTransactionSaleSummaryModel GetPosTransactionSummary()
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var model = new PosTransactionSaleSummaryModel();
                var posTransactionsToday = uow.PosTransaction.GetAll(DateTime.Now);
                // Get Transactions Today
                model.SaleToday = posTransactionsToday.Sum(x => x.Total).Value;
                // Get Transactions for the week
                var firstDayofWeek = DateTime.Now.StartOfWeek(DayOfWeek.Monday);
                for (int i = 0; i < 7; i++)
                {
                    var day = firstDayofWeek.AddDays(i);
                    var posTransactionsWeek = uow.PosTransaction.GetAll(day);
                    model.SaleWeek += posTransactionsWeek.Sum(x => x.Total).Value;
                }
                // Get Transactions for the month
                int daysInMonth = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
                for (int i = 0; i < daysInMonth; i++)
                {
                    var day = firstDayofWeek.AddDays(i);
                    var posTransactionsMonth = uow.PosTransaction.GetAll(day);
                    model.SaleMonth += posTransactionsMonth.Sum(x => x.Total).Value;
                }
                return model;
            }
           
        }


        public List<PreviousTransactionListModel> GetTransactions(string criteria, DateTime dateFrom, DateTime dateTo)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var models = new List<PreviousTransactionListModel>();
                var posTransactions = uow.PosTransaction.GetAll(criteria, dateFrom, dateTo, isComplete: true);
                foreach (var item in posTransactions)
                {
                    var model = new PreviousTransactionListModel();
                    model.ID = item.POSTransactionID;
                    model.AmountTendered = !item.AmountTender.HasValue ? 0 : item.AmountTender.Value;
                    model.Date = item.CreateTimeStamp;
                    model.Quantity = item.PosTransactionProducts.Sum( x => x.Quantity);
                    model.Total = !item.Total.HasValue ? 0 : item.Total.Value;
                    model.TransactionCode = item.TransactionCode;
                    models.Add(model);
                }
                return models;

            }
        }


        public void UpdateQuantity(int posTransactionProductID, int currentQuantityValue)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var objPosTransactionProduct = uow.PosTransactionProducts.Get(posTransactionProductID);
                var objProduct = uow.Products.Get(objPosTransactionProduct.ProductID);
                var objCompute = this.ComputeUpdateQuantity(objProduct.Quantity, objPosTransactionProduct.Quantity, currentQuantityValue, objProduct.Price.Value);

                if (objProduct.Limit > objCompute.AvailableQuantity)
                {
                    throw new ApplicationException("Product Limit ("+ objProduct.Limit.ToString() +") Reach");
                }
                objPosTransactionProduct.Quantity = currentQuantityValue;
                objProduct.Quantity = objCompute.AvailableQuantity;
                uow.PosTransactionProducts.Edit(objPosTransactionProduct);
                uow.Products.Edit(objProduct);
                uow.Complete();
            }
        }


        public TransactionProductModel GetProductTransaction(int productTransactionID)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var obj = uow.PosTransactionProducts.GetBy(productTransactionID);
                var model = new TransactionProductModel();
                if (obj != null)
                {
                   
                    model.ID = obj.PosTransactionProductID;
                    model.ProductName = obj.Product.Description;
                    model.AvailableQuantity = obj.Product.Quantity;
                    model.Price = obj.Product.Price;
                    model.Total = obj.Product.Price.Value * obj.Quantity;
                    model.PurchaseQuantity = obj.Quantity;
                    return model;
                }
                else
                {
                    throw new ApplicationException("Product not found!");
                }
                
                
            }
        }
        /// <summary>
        /// Computes the quantity of item on updating or adding item
        /// </summary>
        /// <param name="available">Current quantity available of item</param>
        /// <param name="initialQuantity">Current quantity of already purchase / added item on transaction</param>
        /// <param name="currentPurchaseQuantity">quantity that added to the purchase item</param>
        /// <param name="unitPrice">amount to item</param>
        /// <returns></returns>
        public UpdateQuantityModel ComputeUpdateQuantity(int available, int initialQuantity, int currentPurchaseQuantity, double unitPrice)
        {
            var model = new UpdateQuantityModel();
             //add operation
                model.AvailableQuantity = available + initialQuantity - currentPurchaseQuantity;
                model.TotalAmount = currentPurchaseQuantity * unitPrice;
                return model;

            
        }




        public void CompletePosTransaction(int _postTransactionID, int memberID, double amountTendered, double total)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var posTransaction = uow.PosTransaction.Get(_postTransactionID);
                posTransaction.CreateTimeStamp = DateTime.Now;
                posTransaction.AmountTender = amountTendered;
                posTransaction.MemberID = memberID;
                posTransaction.Total = total;
                posTransaction.IsComplete = true;
                uow.PosTransaction.Edit(posTransaction);
                uow.Complete();
            }
        }


        public PosTransactionDetail GetPosTransactionDetail(int posTransactionID)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var obj = uow.PosTransaction.GetBy(posTransactionID);
                var model = new PosTransactionDetail();
                if (obj != null)
                {
                    model.AmountTendered = obj.AmountTender.ToString();
                    model.Cashier = obj.User.FirstName + " " + obj.User.LastName;
                    model.Change = (obj.AmountTender - obj.Total).ToString();
                    model.DateTimePurchase = obj.CreateTimeStamp.ToString();
                    model.MemberName = obj.Member.FullName;
                    model.Quantity = obj.PosTransactionProducts.Sum(x =>x.Quantity).ToString();
                }
                return model;

            }
        }


        public List<PosTransactionProductModel> GetPosTransactionProducts(int posTransactionID)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var objs = uow.PosTransactionProducts.GetAllBy(posTransactionID);
                var models = new List<PosTransactionProductModel>();
                foreach (var item in objs)
                {
                    var model = new PosTransactionProductModel();
                    model.ID = item.PosTransactionProductID;
                    model.ProductName = item.Product.Description;
                    model.UnitPrice = item.Product.Price;
                    model.Quantity = item.Quantity;
                    model.SubTotal = model.UnitPrice.Value * model.Quantity;
                    models.Add(model);

                }
                
                return models;

            }
        }


        public List<PreviousTransactionListModel> GetDailyTransactions(string criteria)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {

                var models = new List<PreviousTransactionListModel>();
                var posTransactions = uow.PosTransaction.GetAll(DateTime.Now, criteria);
                foreach (var item in posTransactions)
                {
                    var model = new PreviousTransactionListModel();
                    model.ID = item.POSTransactionID;
                    model.AmountTendered = !item.AmountTender.HasValue ? 0 : item.AmountTender.Value;
                    model.Date = item.CreateTimeStamp;
                    model.Quantity = item.PosTransactionProducts.Sum(x => x.Quantity);
                    model.Total = !item.Total.HasValue ? 0 : item.Total.Value;
                    model.TransactionCode = item.TransactionCode;
                    models.Add(model);
                }
                return models;
            }
        }

        public List<PreviousTransactionListModel> GetWeeklyTransactions(string criteria)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                 var models = new List<PreviousTransactionListModel>();
                // Get Transactions for the week
                var firstDayofWeek = DateTime.Now.StartOfWeek(DayOfWeek.Monday);
                    for (int i = 0; i < 7; i++)
                    {
                        var day = firstDayofWeek.AddDays(i);
                        var posTransactions = uow.PosTransaction.GetAll(day, criteria);
                        foreach (var item in posTransactions)
                        {
                            var model = new PreviousTransactionListModel();
                            model.ID = item.POSTransactionID;
                            model.AmountTendered = !item.AmountTender.HasValue ? 0 : item.AmountTender.Value;
                            model.Date = item.CreateTimeStamp;
                            model.Quantity = item.PosTransactionProducts.Sum(x => x.Quantity);
                            model.Total = !item.Total.HasValue ? 0 : item.Total.Value;
                            model.TransactionCode = item.TransactionCode;
                            models.Add(model);
                        }
                }
                
                return models;
                
            }
        }

        public List<PreviousTransactionListModel> GetMonthlyTransactions(string criteria)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var models = new List<PreviousTransactionListModel>();
                // Get Transactions for the week
                    var posTransactions = uow.PosTransaction.GetAllBy(DateTime.Now.Month,DateTime.Now.Year, criteria);
                    foreach (var item in posTransactions)
                    {
                        var model = new PreviousTransactionListModel();
                        model.ID = item.POSTransactionID;
                        model.AmountTendered = !item.AmountTender.HasValue ? 0 : item.AmountTender.Value;
                        model.Date = item.CreateTimeStamp;
                        model.Quantity = item.PosTransactionProducts.Sum(x => x.Quantity);
                        model.Total = !item.Total.HasValue ? 0 : item.Total.Value;
                        model.TransactionCode = item.TransactionCode;
                        models.Add(model);
                    }
                return models;

            }
        }
    }
    public static class DateTimeExtensions
    {
        public static DateTime StartOfWeek(this DateTime dt, DayOfWeek startOfWeek)
        {
            int diff = (7 + (dt.DayOfWeek - startOfWeek)) % 7;
            return dt.AddDays(-1 * diff).Date;
        }
        public static DateTime LastDayOfMonth(this DateTime date) { 
            return new DateTime(date.Year, date.Month, DateTime.DaysInMonth(date.Year, date.Month)); 
        }
    }
   
}
