using POS.Queries.Core.Domain;
using POS.Queries.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace POS.Queries.Persistence.Repositories
{
    public class ProductLogRepo : Repository<ProductLog>, IProductLogRepo
    {
        public ProductLogRepo(DataContext context)
            : base(context)
        {

        }
        public DataContext DataContext
        {
            get
            {
                return Context as DataContext;
            }
        }

        public Product GetProduct(int productID)
        {
            return DataContext.Products.Include(p => p.Supplier)
                .FirstOrDefault(p => p.ProductID == productID);
        }


        public IEnumerable<ProductLog> GetAll(string criteria)
        {
            return DataContext.ProductLogs
                   .Where(p => p.Action.Contains(criteria));
        }







        public IEnumerable<ProductLog> GetAll(int _productID, string criteria)
        {
            return DataContext.ProductLogs.Include(x => x.Product)
                    .Where(p => p.ProductID == _productID && p.Action.Contains(criteria)).ToList();
        }
    }
}
