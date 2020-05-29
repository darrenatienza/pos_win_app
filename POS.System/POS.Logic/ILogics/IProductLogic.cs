using POS.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Logic.ILogics
{
    public interface IProductLogic
    {


        List<ProductModel> GetProductList(string criteria);

        void Delete(int posTransactionProductID);

        ProductModel Get(int _productID);
    }
}
