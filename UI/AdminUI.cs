using OOp_Console_Application.BL;
using OOp_Console_Application.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOp_Console_Application.UI
{
    class AdminUI
    {
       public static Product  AddProducts()
        {
            string name = Validtions.ProductName();
           float price = Validtions.ProductPrice();
            int quantity = Validtions.ProductQuantity();
            Product obj = new Product(name, price, quantity);
            return obj;
        }
 



    }
}

