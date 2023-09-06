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
        public static void PrintSegment(int x, int y)
        {
            SetCursorPosition(x, y);
            Write("#");
        }
    }
}
