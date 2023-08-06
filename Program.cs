using OOp_Console_Application.BL;
using OOp_Console_Application.DL;
using OOp_Console_Application.UI;
using System.Threading;
using static System.Console;


namespace OOp_Console_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonDL.LoadCredentials();
            ProductsDL.LoadProducts();
            while (true)
            {
                
                CursorVisible = false;
                int option = Menus.ShowMenu(MenusOptions.UserLoginMenu(), "Login");
                Clear();
                if (option == 1)
                {
                    Login.SignUpOption("Customer","Sign up");
                    Thread.Sleep(800);
                }
                else if (option == 2)
                {
                    Person obj = Login.Signin("Sign In");
                    if (obj != null)
                    {
                        
                        if (obj.Role == "Customer"&&obj is Customer user)
                        {
                            Instructions.Successfully("Customer Sign in");
                            Thread.Sleep(800);
                            Controllers.UserController(user);
                        }
                        else if ("Owner" == obj.Role)
                        {
                            Instructions.Successfully("Owner Sign in");
                            Thread.Sleep(800);
                            Controllers.AdminController(obj);
                        }
                        else if (obj.Role == "Admin")
                        {
                            Instructions.Successfully("Admin Sign in");
                            Thread.Sleep(1000);
                            Controllers.AdminController(obj);
                        }

                    }
                    else
                    {
                        Instructions.NoAcceess();
                    }
                }
                else if (option == 3)
                {
                   
                    break;
                }

                }
            }




        }
    }


