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
    class CustomerUI
    {
        public static Product AddProducts()
        {
            string name;
            int quantity;
            while (true)
            {
                name = InPuts.Messege("Product Name");
                bool Exist = ProductsDL.CheckProductExist(name);
                if (Exist)
                {
                    quantity = Validtions.ProductQuantity();
                    Product AllClear = ProductsDL.CheckQuantity(quantity, name);
                    if (AllClear != null)
                    {
                        Product obj = new Product(AllClear.Name, AllClear.Price, quantity);
                        return obj;
                    }
                    else
                    {
                        Instructions.Exceede();
                        return null;
                    }

                }
                else
                {
                    Instructions.NotExits("prodcut");
                    return null;
                }
            
            }
        }

        public static void Help()
        {
            
            WriteLine("Please follow the instructions below:");
            WriteLine();
            ForegroundColor = ConsoleColor.Blue;
            WriteLine("1. Use lowercase letters when entering data.");
            WriteLine("2. Avoid adding spaces in names.");
            WriteLine("3. Pay close attention to the instructions provided on each page.");
            WriteLine();

            ForegroundColor = ConsoleColor.DarkRed;
            WriteLine("For further assistance, please contact us:");
            WriteLine();

            ResetColor();
            ForegroundColor = ConsoleColor.DarkYellow;
            WriteLine("Contact Information:");
            WriteLine("Name:         M.Awais Ashraf");
            WriteLine("Email:        mhawais431@gmail.com");
            WriteLine("Contact No.:  03154193750");
            WriteLine();
            WriteLine("Thank you for using our application!");
            ResetColor();
            Instructions.ClearScreen();
          
        }
    }
}
