using ConsoleTables;
using OOp_Console_Application.BL;
using System;
using System.Collections.Generic;
using System.IO;
using static System.Console;


namespace OOp_Console_Application.DL
{
    class ProductsDL
    {
        static List<Product> AllProductsList = new List<Product>();
        public static void AddProductsInList(Product obj)
        {
            AllProductsList.Add(obj);
        }
    
        public static bool CheckProductExist(string name)
        {
            foreach (var item in AllProductsList)
            {
                if (name == item.Name)
                {
                    return true;
                }
            }
            return false;
        }
        public static void ViewStock( )
        {
            ForegroundColor = ConsoleColor.DarkYellow;
            var table = new ConsoleTable("#", "Name", "Price","Quantity");
            int index = 1;
            foreach (var product in AllProductsList)
            {
                table.AddRow(
                    (AllProductsList.IndexOf(product)+(index)),
                    product.Name.PadRight(20),
                    product.Price.ToString("C").PadRight(10),
                    product.Quantity.ToString()
                   
                ) ;
          

            }
            table.Write();


        }
        public static bool DeleteProduct(string name)
        {
            foreach (var item in AllProductsList)
            {
                if (name == item.Name)
                {
                    AllProductsList.Remove(item);
                    return true;
                }
            }
            return false;

        }
        public static void SearchItem(string name)
        {
            ForegroundColor = ConsoleColor.Green;
            var table = new ConsoleTable("#", "Name", "Price", "Quantity");
            int index = 1;
            foreach (var product in AllProductsList)
            {
                if (name == product.Name)
                {
                    table.AddRow(
                      (AllProductsList.IndexOf(product) + (index)),
                      product.Name.PadRight(20),
                      product.Price.ToString().PadRight(10),
                      product.Quantity.ToString("C"));
                      table.Write();
                      break;
                }
          
            }
        }
        public static void Edit(string new_name, string name)
        {
            foreach (var item in AllProductsList)
            {
                if (name == item.Name)
                {
                    item.Name = new_name;
                    break;

                }
            }

        }
        public static void Edit(float new_price, string name)
        {
            foreach (var item in AllProductsList)
            {
                if (name == item.Name)
                {
                    item.Price = new_price;
                    break;

                }
            }

        }
        public static void Edit(int  new_quantity, string name)
        {
            foreach (var item in AllProductsList)
            {
                if (name == item.Name)
                {
                    item.Quantity = new_quantity;
                    break;

                }
            }
        }
        public static Product CheckQuantity(int quantiy, string name)
        {
            foreach (var item in AllProductsList)
            {
                if (name == item.Name && quantiy <= item.Quantity)
                {
                    item.Quantity -= quantiy;
                    return item;
                }

            }
            return null;
        }
        public static void StoreProductsinFile()
        {
    
            string path = @"E:\OOP\OOp Console Application\DL\Products.txt";
            StreamWriter obj = new StreamWriter(path);
            char ch = (char)223;
            foreach (var product in AllProductsList)
            {
               obj.WriteLine(product.Name + ch + product.Price+ ch + product.Quantity);
            }
            obj.Flush();
            obj.Close();
        }
        public static void LoadProducts()
        {
            char ch = (char)223;
            string path = @"E:\OOP\OOp Console Application\DL\Products.txt";
            string Line;
            StreamReader obj = new StreamReader(path);
            if (File.Exists(path))
            {
                while ((Line = obj.ReadLine()) != null)
                {
                    string[] array = Line.Split(ch);
                    string Name = array[0];
                    float Price= float.Parse(array[1]);
                    int Quantity = int.Parse(array[2]);
                    Product obj1 = new Product(Name, Price,Quantity);
                    AddProductsInList(obj1);

                }
            }
            obj.Close();
        }
    }
}