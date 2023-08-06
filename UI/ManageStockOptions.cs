using OOp_Console_Application.BL;
using OOp_Console_Application.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace OOp_Console_Application.UI
{
    class ManageStockOptions
    {
        public static void Option1()
        {

            while (true)
            {
                Header.TinyHeader("Add");
                Product obj = AdminUI.AddProducts();
                ProductsDL.AddProductsInList(obj);
                Instructions.Successfully("Product Added");
                ProductsDL.StoreProductsinFile();
                string suggestion = Instructions.Suggestion();
                if (suggestion == "n")
                {
                    Instructions.ClearScreen();
                    break;
                }
                else
                {
                    Clear();
                }
            }
        }
        public static void Option2()
        {
            Header.TinyHeader("Stock");
            ProductsDL.ViewStock();
            Instructions.ClearScreen();
        }
        public static void Option3()
        {
            Header.TinyHeader("Delete");
            string product = InPuts.Messege("Product Name;");
            bool Exist = ProductsDL.DeleteProduct(product);
            if (Exist)
            {
                Instructions.Successfully("Product Deleted");
                Instructions.ClearScreen();

            }
            else
            {
                Instructions.NotExits("product");
            }
        }
        public static void Option4()
        {
            Header.TinyHeader("Edit");
            Controllers.EditController();

        }
        public static void Option5()
        {
            Header.TinyHeader("Search");
            string product = InPuts.Messege("Product Name");
            bool Exist = ProductsDL.CheckProductExist(product);
            if (Exist)
            {
           
                ProductsDL.SearchItem(product);
                Instructions.ClearScreen();
            }
            else
            {
                Instructions.NotExits("product");
            }
        }


    }

}

