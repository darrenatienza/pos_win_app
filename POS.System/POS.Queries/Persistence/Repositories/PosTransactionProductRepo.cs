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
    public class PosTransactionProductRepo : Repository<PosTransactionProduct>, IPosTransactionProductRepo
    {
        public PosTransactionProductRepo(DataContext context)
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




        public IEnumerable<PosTransactionProduct> GetAllBy(int _posTransanctionID)
        {
            return DataContext.PosTransactionProducts.Include(x => x.Product).Include(x => x.PosTransaction).Where(x => x.PosTransactionID == _posTransanctionID).ToList();
        }


        public PosTransactionProduct GetBy(int productTransactionID)
        {
            return DataContext.PosTransactionProducts
                .Include(x => x.Product)
                .Include(x => x.PosTransaction)
                .FirstOrDefault(x => x.PosTransactionProductID == productTransactionID);
        }
    }
}
