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
    public class SupplierLogic : ISupplierLogic
    {
        public SupplierLogic() { }




        public List<SupplierListModel> GetSupplierList(string criteria)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var models = new List<SupplierListModel>();
                var suppliers = uow.Suppliers.GetAll(criteria);
                foreach (var supplier in suppliers)
                {
                    var model = new SupplierListModel();
                    model.SupplierID = supplier.SupplierID;
                    model.Description = supplier.Description;
                    model.Address = supplier.Address;
                    models.Add(model);
                }
                return models;
            }
        }


        public void Delete(int supplierID)
        {
            using (var uow = new UnitOfWork(new DataContext()))
            {
                var supplier = uow.Suppliers.Get(supplierID);
                uow.Suppliers.Remove(supplier);
                uow.Complete();
            }
        }
    }
}
