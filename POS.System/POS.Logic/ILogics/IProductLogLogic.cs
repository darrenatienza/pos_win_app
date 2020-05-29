using POS.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Logic.ILogics
{
    public interface IProductLogLogic
    {


       

        ProductLogModel GetProduct(int productID);

        void Update(int productID, ProductLogModel model);

        List<ProductLogModel> GetAll(string criteria);

        List<ProductLogModel> GetAll(int _productID, string p);
    }
}
