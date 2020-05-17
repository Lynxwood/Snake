using Zmeyka.Enums;
using Zmeyka.Factory;
using Zmeyka.Helpers;
using Zmeyka.Installers;
using Zmeyka.Lines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Zmeyka
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();

            ConsoleKey click = Console.ReadKey().Key;

            if (click == ConsoleKey.Enter)
            {
                Console.Clear();

                LineInstaller line = new LineInstaller();
                line.DrawShapes();

                Point food = FoodFactory.GetRandomFood(119, 20, '+');

                Console.ForegroundColor = ColorHelper.GetRandomColor(new Random().Next(1, 5));
                food.DrawPoint();
                Console.ResetColor();

                Snake snake = new Snake();
                snake.CreateSnake(5, new Point(5, 5, 'z'), DirectionEnum.Right);
                snake.DrawLine();

                while (true)
                {
                    if (snake.Eat(food))
                    {
                        food = FoodFactory.GetRandomFood(119, 20, '+');
                        Console.ForegroundColor = ColorHelper.GetRandomColor(new Random().Next(1, 5));
                        food.DrawPoint();
                        Console.ResetColor();
                    }

                    Thread.Sleep(500);
                    snake.Move();

                    if (Console.KeyAvailable)
                    {
                        ConsoleKeyInfo key = Console.ReadKey();
                        snake.PressKey(key.Key);
                    }
                }
            }

            else if (click == ConsoleKey.I)
            {
                Console.Clear();
                Rules rules = new Rules();
            }

            else if (click == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
        }
    }
}
