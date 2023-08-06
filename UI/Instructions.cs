using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;


namespace OOp_Console_Application.UI
{
    class Instructions
    {
      

        public static void ClearScreen()
        {
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine();
            WriteLine();
            WriteLine("Press Any key to continue.........");
            ResetColor();
            ReadKey();
            Clear();
        }
        public static void AlreadyPresent(string field)
        {
            ForegroundColor = ConsoleColor.Red;
            WriteLine($"{field} with this name already present !");
            Thread.Sleep(1000);
            ResetColor();
            Beep();
        
        }
        public static string Suggestion()
        {
            ForegroundColor = ConsoleColor.Magenta;
            Write("Do You Want to Add More Products(enter n for exit)");
            string suggestion = (ReadLine());
            ResetColor();
            return suggestion;
        }
        public static void Successfully(string msg)
        {
            ForegroundColor = ConsoleColor.Green;
            WriteLine($"{msg}  Sucessfullly......");
            ResetColor();
            Thread.Sleep(900);
        }
        public static void NotExits(string field)
        {
            ForegroundColor = ConsoleColor.DarkRed;
            WriteLine($"{field} Not Exists......");
            ResetColor();
            Beep();
            ClearScreen();
        } public static void NoAcceess()
        {
            ForegroundColor = ConsoleColor.DarkRed;
            WriteLine("Wrong Credentials......");
            Beep();
            ResetColor();
            Thread.Sleep(1200);
        }
        public static void Exceede()
        {
            ForegroundColor = ConsoleColor.DarkRed;
            WriteLine("Product Qunatity Exceede......");
            Beep();
            ResetColor();
            ClearScreen();

        }
        public static void Reenter(string msg)
        {
            ForegroundColor = ConsoleColor.DarkRed;
            WriteLine(msg);
            Beep();
            ResetColor();
        }
        public static void Confirmed()
        {
            ForegroundColor = ConsoleColor.Cyan;
            WriteLine("Password Confirmed:....");
            ResetColor();
            Thread.Sleep(1200);
        }
    }
}
