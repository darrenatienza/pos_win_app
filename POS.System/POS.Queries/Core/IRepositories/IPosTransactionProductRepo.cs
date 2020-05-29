using POS.Queries.Core.Domain;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Queries.Core.IRepositories
{
    public interface IPosTransactionProductRepo : IRepository<PosTransactionProduct>
    {


      


        IEnumerable<PosTransactionProduct> GetAllBy(int _posTransanctionID);


        PosTransactionProduct GetBy(int productTransactionID);
    }
}
