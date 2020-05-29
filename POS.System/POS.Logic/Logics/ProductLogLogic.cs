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
    public class ProductLogLogic : IProductLogLogic
    {
        public ProductLogLogic() { }




        public List<ProductModel> GetProductList(string criteria)
        {
            
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var models = new List<ProductModel>();
                var products = uow.Products.GetAll(criteria);
                foreach (var product in products)
                {
                    var model = new ProductModel();
                    model.ProductID = product.ProductID;
                    model.Code = product.Code;
                    model.Description = product.Description;
                    models.Add(model);
                }
                return models;
            }
        }


        public void Delete(int productID)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var product = uow.Products.Get(productID);
                uow.Products.Remove(product);
                uow.Complete();
            }
        }

        public ProductLogModel GetProduct(int productID)
        {
            throw new NotImplementedException();
        }


        public void Update(int productID, ProductLogModel model)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var product = uow.Products.Get(productID);
                var productLog = new ProductLog();
               
                if (model.Action == "Stock In")
                {
                    product.Quantity = product.Quantity + model.Quantity;
                }
                else
                {
                    // quantity to remove
                    //check for limit to be remove
                    var newQuantity = product.Quantity - model.Quantity;
                    if (newQuantity < product.Limit)
                    {
                        throw new ApplicationException("Quantity result must be greater than product limit!");
                    }
                    else
                    {
                        product.Quantity = newQuantity;
                    }
                }
                productLog.Action = model.Action;
                productLog.CreateTimeStamp = model.Date;
                productLog.ProductID = productID;
                productLog.Quantity = model.Quantity;
                productLog.Remarks = model.Remarks;
                uow.ProductLogs.Add(productLog);
                uow.Products.Edit(product);
                uow.Complete();
            }
        }


        public List<ProductLogModel> GetAll(string criteria)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var models = new List<ProductLogModel>();
                var products = uow.ProductLogs.GetAll(criteria);
                foreach (var product in products)
                {
                    var model = new ProductLogModel();
                    model.ProductID = product.ProductID;
                    model.Action = product.Action;
                    model.ProductName = product.Product.Description;
                    model.Quantity = product.Quantity;
                    model.Remarks = product.Remarks;
                    models.Add(model);
                }
                return models;
            }
        }


        public List<ProductLogModel> GetAll(int _productID, string criteria)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var models = new List<ProductLogModel>();
                var products = uow.ProductLogs.GetAll(_productID, criteria).OrderByDescending(x => x.CreateTimeStamp);
                foreach (var product in products)
                {
                    var model = new ProductLogModel();
                    model.Date = product.CreateTimeStamp;
                    model.ProductID = product.ProductID;
                    model.Action = product.Action;
                    model.ProductName = product.Product.Description;
                    model.Quantity = product.Quantity;
                    model.Remarks = product.Remarks;
                    models.Add(model);
                }
                return models;
            }
        }
    }
}
