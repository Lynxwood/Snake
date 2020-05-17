using System;
using System.Collections.Generic;
using System.Text;

namespace Zmeyka
{
    class Line
    {
        public void HorizontalLine(int left, int top, char symbol, int length)
        {
            for(int i = left; i < length; i++)
            {
                //Console.SetCursorPosition(i, top);
                //Console.Write(symbol);
                Draw(i, top, symbol);
            }
        }

        public void VerticalLine(int left, int top, char symbol, int length)
        {
            for (int i = top; i < length; i++)
            {
                //Console.SetCursorPosition(left, i);
                //Console.Write(symbol);
                Draw(left, i, symbol);
            }
        }

        public void Draw(int left, int top, char symbol)
        {
            Console.SetCursorPosition(left, top);
            Console.Write(symbol);
        }
    }
}
