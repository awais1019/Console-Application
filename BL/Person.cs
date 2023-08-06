using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace OOp_Console_Application
{
   public abstract class Person
    {
        public string Name { get; set; }
        public string Password  { get; set; }
        public string Role  { get; set; }
        protected string name3;
      
        public Person(string name,string password,string role)
        {
            this.Name = name;
            this.Password = password;
            this.Role = role;
        }
        public abstract int Menu();

       
     
    }
}
