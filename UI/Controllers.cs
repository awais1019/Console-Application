using OOp_Console_Application.BL;
using OOp_Console_Application.DL;
using System;
using System.Threading;
using static System.Console;


namespace OOp_Console_Application.UI
{
    class Controllers
    {
        public static void MangeStockController()
        {
            while (true)
            {
                int option = Menus.ShowMenu(MenusOptions.ManageStockMenu(), "Stock");
                Clear();
                if (option == 1)
                {
                    ManageStockOptions.Option1();
                }
                else if (option == 2)
                {
                    ManageStockOptions.Option2();
                }

                else if (option == 3)
                {
                    ManageStockOptions.Option3();
                }
                else if (option == 4)
                {
                    ManageStockOptions.Option4();
                }
                else if (option == 5)
                {
                    ManageStockOptions.Option5();
                }
                else
                {
                    ProductsDL.StoreProductsinFile();
                    break;
                }
            }
        }
        public static void EditController()
        {

            while (true)
            {
                int opinion = Menus.ShowMenu(MenusOptions.EditMenu(), "Edit ");
                Clear();
                Header.TinyHeader("Edit");
                if (opinion == 1)
                {
                    EditOptions.Option1();

                }
                else if (opinion == 2)
                {
                    EditOptions.Option2();

                }
                else if (opinion == 3)
                {
                    EditOptions.Option3();

                }
                else if (opinion == 4)
                {
                    EditOptions.Option4();

                }
                else if (opinion == 5)
                {
                    break;
                }

            }
        }
        public static void MangeAdminsController()
        {
            while (true)
            {
                int option = Menus.ShowMenu(MenusOptions.ManageAdminMenu(), "Manage Admins");
                Clear();
                if (option == 1)
                {
                    Header.TinyHeader("All Admins");
                    PersonDL.viewAdmins();
                    Instructions.ClearScreen();
                }
                else if (option == 2)
                {
                    Person obj = Login.Signin("Conformation Password");
                    if (obj != null)
                    {

                        Instructions.Confirmed();
                        Clear();
                        Login.AdminSignUpOption("Admin", "Add Admin");

                    }
                    else
                    {

                        Instructions.NoAcceess();
                        ForegroundColor = ConsoleColor.Cyan;
                        WriteLine("Use Owner Credentials.......");
                        ResetColor();
                        Thread.Sleep(1200);
                    }
                }
                else if (option == 3)
                {
                    Person obj = Login.Signin("Confirmation Password");
                    if (obj != null)
                    {
                        Instructions.Confirmed();
                        Clear();
                        Header.TinyHeader("Delete Admin");
                        string name = InPuts.Messege("Admin Name");
                        bool Exist = PersonDL.DeleteAdmin(name);
                        if (Exist)
                        {
                            Instructions.Successfully("Admin Deleted");
                        }
                        else
                        {
                            Instructions.NotExits("Admin");
                        }
                    }
                    else
                    {
                        Instructions.NoAcceess();
                        ForegroundColor = ConsoleColor.Cyan;
                        WriteLine("Use Owner Credentials.............");
                        Thread.Sleep(1200);
                        ResetColor();
                    }
                }

                else
                {
                 
                    break;
                }
            }
        }


        public static void AdminController(Person obj)
        {
            while (true)
            {
                int option = obj.Menu();
                Clear();
                if (option == 1)
                {
                    MangeStockController();
                }
                else if (option == 2)
                {
                    MangeCustomerController();

                }
                else if (option == 3)
                {
                    MangeAdminsController();
                }

                else
                {

                    break;
                }

            }
        }

        public static void UserController(Customer user)
        {
            while (true)
            {
                int opinion = user.Menu();
                Clear();
                if (opinion == 1)
                {
                    ManageStockOptions.Option2();
                }

                else if (opinion == 2)
                {

                    while (true)
                    {

                        Header.TinyHeader("Purchase");
                        Product obj = CustomerUI.AddProducts();
                        if (obj != null)
                        {
                            Instructions.Successfully("Product Selected");
                            user.AddUserProductsinList(obj);
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
                        else
                        {
                            break;
                        }
                    }

                }
                else if (opinion == 3)
                {
                    ManageStockOptions.Option5();
                }
                else if (opinion == 4)
                {
                    Header.TinyHeader("Bill");

                    float totalbill = user.DisplayBill();
                    BackgroundColor = ConsoleColor.White;
                    ForegroundColor = ConsoleColor.Black;
                    WriteLine($"\n\tTotal bill is: {totalbill.ToString("C")}");
                    ResetColor();
                    Instructions.ClearScreen();

                }
                else if (opinion == 5)
                {
                    Header.TinyHeader("View Admin");
                    PersonDL.viewAdminswithoutPassword();
                    Instructions.ClearScreen();

                }
                else if (opinion == 6)
                {
                    Header.TinyHeader("Help");
                    CustomerUI.Help();
                }
                else
                {
                    break;
                }
            }
        }
        public static void MangeCustomerController()
        {
            while (true)
            {
                int option = Menus.ShowMenu(MenusOptions.ManageCustomerMenu(), "Manage Customer");
                Clear();
                if (option == 1)
                {
                    Header.TinyHeader("All Customers");
                    PersonDL.viewCustomers();
                    Instructions.ClearScreen();
                }

                else if (option == 2)
                {
                    Header.TinyHeader("Delete Customer");
                    string name = InPuts.Messege("Customer Name");
                    bool Exist = PersonDL.DeleteCustomer(name);
                    if (Exist)
                    {
                        Instructions.Successfully("Customer Deleted");
                    }
                    else
                    {
                        Instructions.NotExits("Customer");
                    }
                }
                else
                {
                    break;
                }
            }
        }
    }
}
