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
    public class ProductLogic : IProductLogic
    {
        public ProductLogic() { }




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
                    model.Price = product.Price;
                    model.Limit = product.Limit;
                    model.Description = product.Description;
                    model.Quantity = product.Quantity;
                    model.SupplierName = product.Supplier.Description;
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


        public ProductModel Get(int _productID)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var product = uow.Products.GetProduct(_productID);
                var model = new ProductModel();
                if (product != null)
                {
                    model.Description = product.Description;
                    model.Remarks = product.Remarks;
                    model.Limit = product.Limit;
                    model.Quantity = product.Quantity;
                    model.Price = product.Price;
                    model.SupplierID = product.SupplierID;
                }
                return model;
            }
        }
    }
}
