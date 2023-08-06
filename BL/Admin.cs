using OOp_Console_Application.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOp_Console_Application.BL
{
    class Admin:Person
    {
        public Admin(string name,string password,string role):base(name,password,role)
        {

        }
        public override int  Menu()
        {
           return    Menus.ShowMenu(MenusOptions.AdminMenu(), "Admin");
        
        }
    }
}
