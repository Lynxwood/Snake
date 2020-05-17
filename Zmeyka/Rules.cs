using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Zmeyka.Installers;

namespace Zmeyka
{
    class Rules
    {
        public Rules()
        {
            Console.Title = "SNAKE GAME";
            Console.SetWindowSize(120, 30);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.CursorVisible = false;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                                              +-----------------------+");
            Console.WriteLine("                                              |         Rules...      |");
            Console.WriteLine("                                              +-----------------------+");
            Console.WriteLine("");
            Console.WriteLine("                                              +-----------------------+");
            Console.WriteLine("                                              | Press Enter to return |");
            Console.WriteLine("                                              +-----------------------+");
            Console.WriteLine("");
            Console.WriteLine("                                              +-----------------------+");
            Console.WriteLine("                                              |   Press esc to quit   |");
            Console.WriteLine("                                              +-----------------------+");

            ConsoleKey click = Console.ReadKey().Key;
            if (click == ConsoleKey.Enter)
            {
                Console.Clear();
                Menu menu = new Menu();
            }
            if (click == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
            Console.ReadKey();
        }
    }
}
