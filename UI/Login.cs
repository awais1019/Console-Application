using OOp_Console_Application.BL;
using OOp_Console_Application.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;

namespace OOp_Console_Application.UI
{
    class Login
    {
        public static Customer Singup(string field2,string field)
        {
            Header.TinyHeader(field);
            string name = Validtions.UserName();
            string password = Validtions.UserPassword();
            string role = Validtions.Role(field2);
            Customer obj = new Customer(name, password, role);
            return obj;
        }
        public static Person Signin(string field)
        {
            Header.TinyHeader(field);
            string name = InPuts.Messege("Name");
            string password =InPuts.Messege("Password");
           Person  obj1= PersonDL.ReturnRole(name,password);
            if(obj1!=null)
            {
                return obj1;
            }
            return null;
           
        }
        public static void SignUpOption(string field, string field2)
        {
            Customer obj = Singup(field, field2);
            bool check = PersonDL.UserExist(obj);
            if (!check)
            {
                Instructions.AlreadyPresent("User");
            }
            else
            {
                PersonDL.AddinList(obj);
                PersonDL.StoreCredentialsinFile();
                Instructions.Successfully($"{field} Added");

            }
        }
            public static void AdminSignUpOption(string field, string field2)
            {
                Admin obj1 = AdminSingup(field, field2);
                bool check = PersonDL.UserExist(obj1);
                if (!check)
                {
                    Instructions.AlreadyPresent("User");
                }
                else
                {
                    PersonDL.AddinList(obj1);
                    PersonDL.StoreCredentialsinFile();
                    Instructions.Successfully($"{field} Added");

                }
            }
        public static Admin AdminSingup(string field2, string field)
        {
            Header.TinyHeader(field);
            string name = Validtions.UserName();
            string password = Validtions.UserPassword();
            string role = Validtions.Role(field2);
            Admin obj = new Admin(name, password, role);
            return obj;
        }

    }
}
