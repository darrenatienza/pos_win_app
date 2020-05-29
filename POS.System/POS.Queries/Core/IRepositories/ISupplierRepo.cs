using POS.Queries.Core.Domain;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Queries.Core.IRepositories
{
    public interface ISupplierRepo : IRepository<Supplier>
    {

        IEnumerable<Supplier> GetAll(string criteria);
    }
}
