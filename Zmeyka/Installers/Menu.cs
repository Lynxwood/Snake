using Zmeyka.Lines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zmeyka.Installers;
using System.Threading;

namespace Zmeyka.Installers
{
    public class Menu
    {
        public Menu()
        {
            Console.Title = "SNAKE GAME";
            Console.SetWindowSize(120, 30);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.CursorVisible = false;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                                              +-----------------------+");
            Console.WriteLine("                                              |  Press Enter to play  |");
            Console.WriteLine("                                              +-----------------------+");
            Thread.Sleep(500);
            Console.WriteLine("");
            Console.WriteLine("                                              +-----------------------+");
            Console.WriteLine("                                              |   Press esc to quit   |");
            Console.WriteLine("                                              +-----------------------+");
            Thread.Sleep(500);
            Console.WriteLine("                               xxxxxxxx                                  xx");
            Console.WriteLine("                            xxx       xx      +-----------------------+  xx");
            Console.WriteLine("                           xx   xxxxxx x      | Press i to read rules |  xx");
            Console.WriteLine("                           x    x   xxxx      +-----------------------+  xx");
            Console.WriteLine("                           xxxxx xxxxxx                                  xx");
            Console.WriteLine("                                xxxxx                                    xx");
            Console.WriteLine("                              xxxxx                                      xx");
            Console.WriteLine("                             xxxx           xxxx xx   xxx       xxxxx    xx     x    xxxx");
            Console.WriteLine("                            xxx            xxx   xx xxx  xx   xxx   xx   xx    xx   xxx xxx");
            Console.WriteLine("                            xxx            xx    xxxx     xx xx      xx  xx   xx   xx     xx");
            Console.WriteLine("                            xx             xx    xxx      xx x        xx xx xxx    xxxxxxxxx");
            Console.WriteLine("                            xx             xx    xx       xx x        xx xxxxx     x");
            Console.WriteLine("                            xx             xx    xx       xx xx      xxx xx  xxx   xx");
            Console.WriteLine("                             xxx         xxx     xx       xx xx      x x xx    xx  xx");
            Console.WriteLine("                               xxxxxxxxxxxx      xx       xx  xx   xx xx xx     xx  xx    xx");
            Console.WriteLine("                                  xxxxxx         xx       xx   xxxxx  xx xx     xx   xxxxxx");
            Console.WriteLine("");
            Console.WriteLine("");  

        }
    }
}
