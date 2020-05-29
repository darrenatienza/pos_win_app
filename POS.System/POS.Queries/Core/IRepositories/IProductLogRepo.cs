using POS.Queries.Core.Domain;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Queries.Core.IRepositories
{
    public interface IProductLogRepo : IRepository<ProductLog>
    {


        IEnumerable<ProductLog> GetAll(string criteria);

        IEnumerable<ProductLog> GetAll(int _productID, string criteria);
    }
}
