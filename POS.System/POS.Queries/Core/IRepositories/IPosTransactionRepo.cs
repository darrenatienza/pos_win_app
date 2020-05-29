using POS.Queries.Core.Domain;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Queries.Core.IRepositories
{
    public interface IPosTransactionRepo : IRepository<PosTransaction>
    {


        //IEnumerable<POSTransaction> GetPosTransations(int posTransactionID);

        PosTransaction GetPosTransaction(int posTransactionID);



        PosTransaction Get(int userID, bool isCompleteTransaction);

        IEnumerable<PosTransaction> GetAll(DateTime dateTime);

        IEnumerable<PosTransaction> GetAll(string criteria, DateTime dateFrom, DateTime dateTo);

        PosTransaction GetBy(int posTransactionID);

        IEnumerable<PosTransaction> GetAll(string criteria, DateTime dateFrom, DateTime dateTo, bool isComplete);

        IEnumerable<PosTransaction> GetAll(DateTime dateTime, string criteria);

        IEnumerable<PosTransaction> GetAllBy(int month, int year, string criteria);
    }
}
