using POS.Queries.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Queries.Core
{
    public interface IUnitOfWork  : IDisposable
    {
        IUserRepo Users { get;}
        IRoleRepo Roles { get;}
        ISupplierRepo Suppliers { get; }
        IProductRepo Products { get; }
        IPosTransactionRepo PosTransaction { get; }
        IPosTransactionProductRepo PosTransactionProducts { get; }
        IChatMessageRepo ChatMessages { get; }
        IProductLogRepo ProductLogs { get; }
        IMemberRepo Members { get; }
        int Complete();
    }
}
