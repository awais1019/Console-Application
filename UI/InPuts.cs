using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace OOp_Console_Application.UI
{
    class InPuts
    {
       public  static string Messege(string field)
        {
            Write($"Enter {field}:");
            string value = ReadLine();
            return value;
        }
    }
}
