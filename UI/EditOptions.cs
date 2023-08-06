using OOp_Console_Application.DL;
using OOp_Console_Application.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOp_Console_Application
{
    class EditOptions
    {
        public static void Option1()
        {
            string product = InPuts.Messege("Product Name");
            bool Exist = ProductsDL.CheckProductExist(product);
            if (Exist)
            {
                string NewName = Validtions.ProductName();
                ProductsDL.Edit(NewName, product);
                Instructions.Successfully("Product Name Change");
                Instructions.ClearScreen();
            }
            else
            {
                Instructions.NotExits("product");
            }
        }



        public static void Option2()
        {
            string product = InPuts.Messege("Product Name");
            bool Exist = ProductsDL.CheckProductExist(product);
            if (Exist)
            {
                float NewPrice = Validtions.ProductPrice();
                ProductsDL.Edit(NewPrice, product);
                Instructions.Successfully("Product Price Change");
                Instructions.ClearScreen();
            }
            else
            {
                Instructions.NotExits("product");
            }

        }
        public static void Option3()

        {
            string product = InPuts.Messege("Product Name");
            bool Exist = ProductsDL.CheckProductExist(product);
            if (Exist)
            {
                int NewQuantity = Validtions.ProductQuantity();
                ProductsDL.Edit(NewQuantity, product);
                Instructions.Successfully("Product Quantity Change");
                Instructions.ClearScreen();
            }
            else
            {
                Instructions.NotExits(product);
            }

        }

        public static void Option4()
        {
            string product = InPuts.Messege("Product Name");
            bool Exist = ProductsDL.CheckProductExist(product);
            if (Exist)
            {
                string NewName = Validtions.ProductName();
                ProductsDL.Edit(NewName, product);
                Instructions.Successfully("Product Name Change");
                float NewPrice = Validtions.ProductPrice();
                ProductsDL.Edit(NewPrice, product);
                Instructions.Successfully("Product Price Change");
                int NewQuantity = Validtions.ProductQuantity();
                ProductsDL.Edit(NewQuantity, product);
                Instructions.Successfully("Product Quantity Change");
                Instructions.ClearScreen();
            }
            else
            {
                Instructions.NotExits("product");
            }
     
        }

    }

}

