using POS.Logic.ILogics;
using POS.Logic.Logics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Logic
{
    public static class Factories
    {
        public static IPosTransactionLogic CreatePosTransaction()
        {
            return new PosTransactionLogic();
        }
        public static IUserLogic CreateUser()
        {
            return new UserLogic();
        }

        public static IProductLogic CreateProducts()
        {
            return new ProductLogic();
        }

        public static ISupplierLogic CreateSupplier()
        {
            return new SupplierLogic();
        }

        public static IChatLogic CreateChat()
        {
            return new ChatLogic();
        }

        public static IProductLogLogic CreateProductLog()
        {
            return new ProductLogLogic();
        }
        public static IMemberLogic CreateMember()
        {
            return new MemberLogic();
        }
    }
}
