using POS.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Logic.ILogics
{
    public interface ISupplierLogic
    {


        List<SupplierListModel> GetSupplierList(string criteria);

        void Delete(int supplierID);
    }
}
