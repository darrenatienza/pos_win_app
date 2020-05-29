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
    public class PosTransactionRepo : Repository<PosTransaction>, IPosTransactionRepo
    {
        public PosTransactionRepo(DataContext context)
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


        /**
        public IEnumerable<POSTransaction> GetPosTransations(int posTransactionID)
        {
            return DataContext.POSTransactions.Include(r => r.PostTransactionProducts).Where(r => r.POSTransactionID == posTransactionID);
        }


        public POSTransaction GetPosTransation(int posTransactionID)
        {
           
        }
         */

        public PosTransaction GetPosTransaction(int posTransactionID)
        {
            return DataContext.PosTransactions.Include(r => r.PosTransactionProducts.Select(x => x.Product)).FirstOrDefault(r => r.POSTransactionID == posTransactionID);
        }


        public PosTransaction Get(int userID, bool isCompleteTransaction)
        {
            return DataContext.PosTransactions.FirstOrDefault(r => r.UserID == userID && r.IsComplete == isCompleteTransaction);
        }





        public IEnumerable<PosTransaction> GetAll(DateTime dateTime)
        {
            return DataContext.PosTransactions.Include(x => x.PosTransactionProducts)
                .Where(x => DbFunctions.TruncateTime(x.CreateTimeStamp) == DbFunctions.TruncateTime(dateTime));
        }


        public IEnumerable<PosTransaction> GetAll(string criteria, DateTime dateFrom, DateTime dateTo)
        {
            return DataContext.PosTransactions.Include(x => x.PosTransactionProducts)
               .Where(x => DbFunctions.TruncateTime(x.CreateTimeStamp) >= DbFunctions.TruncateTime(dateFrom)
                   && DbFunctions.TruncateTime(x.CreateTimeStamp) <= DbFunctions.TruncateTime(dateTo)
                   && x.TransactionCode.Contains(criteria)).ToList();
        }


        public PosTransaction GetBy(int posTransactionID)
        {
            return DataContext.PosTransactions.Include(x => x.Member).Include(x => x.User).Include(x => x.PosTransactionProducts).FirstOrDefault(x => x.POSTransactionID == posTransactionID);
        }


        public IEnumerable<PosTransaction> GetAll(string criteria, DateTime dateFrom, DateTime dateTo, bool isComplete)
        {
            return DataContext.PosTransactions.Include(x => x.PosTransactionProducts)
              .Where(x => DbFunctions.TruncateTime(x.CreateTimeStamp) >= DbFunctions.TruncateTime(dateFrom)
                  && DbFunctions.TruncateTime(x.CreateTimeStamp) <= DbFunctions.TruncateTime(dateTo)
                  && x.TransactionCode.Contains(criteria) && x.IsComplete == isComplete).ToList();
        }


        public IEnumerable<PosTransaction> GetAll(DateTime dateNow, string criteria)
        {
            return DataContext.PosTransactions.Include(x => x.PosTransactionProducts)
                .Where(x => DbFunctions.TruncateTime(x.CreateTimeStamp) == DbFunctions.TruncateTime(dateNow)
                    && x.TransactionCode.Contains(criteria) && x.IsComplete == true).ToList();
        }


        public IEnumerable<PosTransaction> GetAllBy(int month, int year, string criteria)
        {
            return DataContext.PosTransactions.Include(x => x.PosTransactionProducts)
                 .Where(x => DbFunctions.TruncateTime(x.CreateTimeStamp).Value.Month == month
                     && DbFunctions.TruncateTime(x.CreateTimeStamp).Value.Year == year
                     && x.TransactionCode.Contains(criteria) && x.IsComplete == true).ToList();
        }
    }
}
