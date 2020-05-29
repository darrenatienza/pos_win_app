using POS.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Logic.ILogics
{
    public interface IPosTransactionLogic
    {
        double GetTotal(int _posTransanctionID);

        void DeleteTransactionProduct(int posTransactionProductID);

        void AddTransactionProduct(string productCode, int posTransactionProductID, int quantity);
        
        void CompletePosTransaction(int _postTransactionID, double amountTendered, double total);

        int GenerateNewTransactionID();

        int GetPreviousPosTransactionID();

        PosTransactionModel GenerateNewTransaction();

        PosTransactionModel GetPreviousPosTransaction();

        PosTransactionSaleSummaryModel GetPosTransactionSummary();

        List<PreviousTransactionListModel> GetTransactions(string criteria, DateTime dateFrom, DateTime dateTo);

        void UpdateQuantity(int posTransactionProductID, int currentValue);

        TransactionProductModel GetProductTransaction(int productTransactionID);

        UpdateQuantityModel ComputeUpdateQuantity(int available, int initialQuantity, int currentPurchaseQuantity, double unitPrice);

        void CompletePosTransaction(int _postTransactionID, int memberID, double amountTendered, double total);

        PosTransactionDetail GetPosTransactionDetail(int posTransactionID);

        List<PosTransactionProductModel> GetPosTransactionProducts(int posTransactionID);

        List<PreviousTransactionListModel> GetDailyTransactions(string criteria);

        List<PreviousTransactionListModel> GetWeeklyTransactions(string criteria);

        List<PreviousTransactionListModel> GetMonthlyTransactions(string criteria);
    }
}
