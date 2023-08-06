
using ConsoleTables;
using OOp_Console_Application.BL;
using System;
using System.Collections.Generic;
using System.IO;
using static System.Console;

namespace OOp_Console_Application.DL
{
    public class PersonDL
    {
        public static List<Person> PersonList = new List<Person>();
        public static void AddinList(Person obj)
        {
            PersonList.Add(obj);
           
        }
        static PersonDL()
        {
            Admin obj = new Admin("Awais", "1234", "Owner");
            AddinList(obj);
        }
        public static bool UserExist(Person obj)
        {
            foreach (var item in PersonList)
            {
                if (obj.Name == item.Name && obj.Password == item.Password)
                {
                    return false;
                }
            }
            return true;

        }
        public static Person ReturnRole(string name, string Password)
        {
            foreach (var item in PersonList)
            {
                if (name == item.Name && Password == item.Password)
                {
                    return item;
                }
            }
            return null;
        }
        public static bool DeleteAdmin(string name)
        {
            foreach (var item in PersonList)
            {
                if ( name == item.Name && item.Role == "Admin")
                {
                    PersonList.Remove(item);
                    return true;
                }
            }
            return false;
        }
        public static bool DeleteCustomer(string name)
        {
            foreach (var item in PersonList)
            {
                if (name == item.Name && item.Role == "Customer")
                {
                    PersonList.Remove(item);
                    return true;
                }
            }
            return false;
        }
        public static void viewAdmins()
        {
            ForegroundColor = ConsoleColor.Cyan;
            var table = new ConsoleTable("#", "Name", "Password");
            int index = 1;
            foreach (var product in PersonList)
            {
                if (product is Customer user && user.Role == "Admin")
                {
                    table.AddRow(
                        (PersonList.IndexOf(product) + (index)),
                        product.Name.PadRight(20),
                        product.Password
                    );
                }

            }
            table.Write();

        }
        public static void viewCustomers()
        {
            ForegroundColor = ConsoleColor.Green;
            var table = new ConsoleTable("#", "Name", "Password");
            int index = 1;
            foreach (var product in PersonList)
            {
                if ( product.Role == "Customer")
                {
                    table.AddRow(
                        (PersonList.IndexOf(product) + (index)),
                        product.Name.PadRight(20),
                        product.Password
                    );
                }

            }
            table.Write();

        }
        public static void viewAdminswithoutPassword()
        {
            ForegroundColor = ConsoleColor.DarkCyan;
            var table = new ConsoleTable("#", "Name");
            int index = 1;
            foreach (var product in PersonList)
            {
                if (product.Role == "Admin")
                {
                    table.AddRow(
                        (PersonList.IndexOf(product) + (index)),
                        product.Name.PadRight(20));

                }

            }
            table.Write();

        }
        public static void StoreCredentialsinFile()
        {
            string path = @"E:\OOP\OOp Console Application\DL\Users.txt";
            StreamWriter obj = new StreamWriter(path);
            char ch = (char)223;
            foreach (var user in PersonList)
            {
 
              obj.WriteLine(user.Name + ch + user.Password + ch + user.Role);
            }
            obj.Flush();
            obj.Close();
        }

        public static void LoadCredentials()
        {
            char ch = (char)223;
            string path = @"E:\OOP\OOp Console Application\DL\Users.txt";
            string Line;
            StreamReader obj = new StreamReader(path);
            if (File.Exists(path))
            {
                while ((Line = obj.ReadLine()) != null)
                {
                    string[] array = Line.Split(ch);
                    string Name = array[0];
                    string Password = array[1];
                    var Role = array[2];
                    if (Role == "Admin" || Role == "Owner")
                    {
                        Admin obj1 = new Admin(Name, Password, Role);
                        AddinList(obj1);
                    }
                    else
                    {
                        Customer obj1 = new Customer(Name, Password, Role);
                        AddinList(obj1);
                    }

                

                }

            }
                  obj.Close();
        }
    }
}
