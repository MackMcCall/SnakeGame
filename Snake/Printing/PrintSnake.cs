using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Snake.Printing
{
    public static class PrintSnake
    {
        public static void PrintSegment(int x, int y, ConsoleColor snakeColor)
        {
            Console.ForegroundColor = snakeColor;
            SetCursorPosition(x, y);
            Write("#");
        }
    }
}
