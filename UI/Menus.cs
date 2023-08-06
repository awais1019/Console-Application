using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace OOp_Console_Application.UI
{
 public   class Menus
    {
        public static int ShowMenu(List<string> menuOptions,string field)
        {
           
            int selectedOption = 0;

            while (true)
            {
                CursorVisible = false;
                Clear();
                Header.MainHeader();
                Header.MenuName(field);
        
            
                    SetCursorPosition(CursorLeft, CursorTop+3);
                for (int i = 0; i < menuOptions.Count; i++)
                {
                    SetCursorPosition(CursorLeft + 80, CursorTop);
                    if (selectedOption == i)
                    {
                        BackgroundColor = ConsoleColor.Red;
                        ForegroundColor = ConsoleColor.White;
                        WriteLine(menuOptions[i] +" <<<--");
                        ResetColor();
                    }
                    else
                    {
                        WriteLine(menuOptions[i]);
                    }
                }

                ConsoleKeyInfo input = ReadKey(true);

                if (input.Key == ConsoleKey.UpArrow)
                {
                    if (selectedOption == 0)
                    {
                        selectedOption = menuOptions.Count - 1;
                    }
                    else
                    {
                        selectedOption--;
                    }
                }
                else if (input.Key == ConsoleKey.DownArrow)
                {
                    if (selectedOption == menuOptions.Count - 1)
                    {
                        selectedOption = 0;
                    }
                    else
                    {
                        selectedOption++;
                    }
                }
                else if (input.Key == ConsoleKey.Enter)
                {
                    return selectedOption + 1;
                }
            }
        }
    
        }
    }

