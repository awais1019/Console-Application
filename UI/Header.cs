using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace OOp_Console_Application.UI
{
    class Header
    {
        public static void MainHeader()
        {
            ForegroundColor = ConsoleColor.Blue;
            WriteLine("\t\t\t\t_________________________________________________________________________________________________________");
            ResetColor();
            WriteLine("\t\t\t\t    ____ ____ _  _ _ ___ ____ ____ _   _    ____ _  _ ___     _  _ ____ ____ ___  _ _ _ ____ ____ ____");
            WriteLine("\t\t\t\t    [__  |__| |\\ | |  |  |__| |__/  \\_/     |__| |\\ | |  \\    |__| |__| |__/ |  \\ | | | |__| |__/ |___");
            WriteLine("\t\t\t\t    ___] |  | | \\| |  |  |  | |  \\   |      |  | | \\| |__/    |  | |  | |  \\ |__/ |_|_| |  | |  \\ |___");
            WriteLine("                                                                                                  ");
            ForegroundColor = ConsoleColor.Red;
            WriteLine("\t\t\t\t                                    ITEMS   MANAGEMENT   SYSTEM                     ");
            ResetColor();
            ForegroundColor = ConsoleColor.Blue;
            WriteLine("\t\t\t\t_________________________________________________________________________________________________________");
            ResetColor();
            WriteLine();
            WriteLine();
        }
        public static void TinyHeader(string field)
        {
            Header.MainHeader();
            ForegroundColor = ConsoleColor.DarkGreen;
            WriteLine($"{field}  Menu");
            ResetColor();
            ForegroundColor = ConsoleColor.Blue;
            WriteLine("----------------------->>>\n\n");
            ResetColor();
        }
        public static void MenuName(string field)
        {

            ForegroundColor = ConsoleColor.DarkBlue;
            WriteLine($"{field.PadLeft(92-7)} Menu");
            WriteLine();
            WriteLine();
            ResetColor();
        }
    }
}
