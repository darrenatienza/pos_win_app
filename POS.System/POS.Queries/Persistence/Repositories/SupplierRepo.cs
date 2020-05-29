using POS.Queries.Core.Domain;
using POS.Queries.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Queries.Persistence.Repositories
{
    public class SupplierRepo : Repository<Supplier>, ISupplierRepo
    {
        public SupplierRepo(DataContext context)
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

        public IEnumerable<Supplier> GetAll(string criteria)
        {
            return DataContext.Suppliers.Where(s => s.Description.Contains(criteria));
        }
    }
}
