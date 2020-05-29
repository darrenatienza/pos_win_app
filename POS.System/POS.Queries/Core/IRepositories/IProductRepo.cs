using POS.Queries.Core.Domain;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Queries.Core.IRepositories
{
    public interface IProductRepo : IRepository<Product>
    {

        Product GetProduct(int ProductID);

        IEnumerable<Product> GetAll(string criteria);

        Product GetExact(string productName);
    }
}
