using POS.Queries.Core;
using POS.Queries.Core.IRepositories;
using POS.Queries.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Queries.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _context;

        public UnitOfWork(DataContext context)
        {
            _context = context;
            Users = new UserRepository(_context);
            Roles = new RoleRepo(_context);
            Products = new ProductRepo(_context);
            Suppliers = new SupplierRepo(_context);
            PosTransaction = new PosTransactionRepo(_context);
            PosTransactionProducts = new PosTransactionProductRepo(_context);
            ChatMessages = new ChatMessageRepo(_context);
            ProductLogs = new ProductLogRepo(_context);
            Members = new MemberRepo(_context);
        }

        public IUserRepo Users { get; private set; }
        public IRoleRepo Roles { get; private set; }
        
        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }







        public ISupplierRepo Suppliers
        {
            get;
            private set;
        }

        public IProductRepo Products
        {
            get;
            private set;
        }


        public IPosTransactionRepo PosTransaction
        {
            get;
            private set;
        }


       


        public IChatMessageRepo ChatMessages
        {
            get;
            private set;
        }


        public IPosTransactionProductRepo PosTransactionProducts
        {
            get;
            private set;
        }


        public IProductLogRepo ProductLogs
        {
            get;
            private set;
        }


        public IMemberRepo Members
        {
            get;
            private set;
        }
    }
}
