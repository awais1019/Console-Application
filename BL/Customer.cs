using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleTables;
using OOp_Console_Application.UI;
using static System.Console;


namespace OOp_Console_Application.BL
{
    public class Customer : Person
    {
        List<Product> UserProductsList = new List<Product>();
      
        public Customer(string name, string password, string role) : base(name, password, role)
        {

        }

        public void AddUserProductsinList(Product obj)
        {


            UserProductsList.Add(obj);


        }

        public float DisplayBill()
        {
            float totalbill = 0;
            float bill = 0;
            ForegroundColor = ConsoleColor.Red;

            var table = new ConsoleTable("#", "Name", "Price", "Quantity", "Bill");
            int index = 1;
            foreach (var product in UserProductsList)
            {
                bill = product.Price * product.Quantity;
                table.AddRow(
                   (UserProductsList.IndexOf(product) + (index)),
                   product.Name.PadRight(20),
                   product.Price.ToString("C").PadRight(10),
                   product.Quantity.ToString().PadRight(10), bill.ToString("C"));
                index++;
                totalbill = totalbill + bill;
            }
            table.Write();

            return totalbill;

        }
        public override int Menu()
        {
            return Menus.ShowMenu(MenusOptions.UserMenu(), "Customer");
        }
    }
}            
   
    

    


  