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
    public class ProductRepo : Repository<Product>, IProductRepo
    {
        public ProductRepo(DataContext context)
            :base(context)
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


        public IEnumerable<Product> GetAll(string criteria)
        {
            return DataContext.Products.Include(p => p.Supplier)
                   .Where(p => p.Code.Contains(criteria) || p.Description.Contains(criteria) || p.Supplier.Description.Contains(criteria));
        }


        public Product GetExact(string productName)
        {
            return DataContext.Products.Include(p => p.Supplier)
                   .Where(p => p.Description == productName).FirstOrDefault();
        }
    }
}
