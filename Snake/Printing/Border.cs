using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Snake.Printing
{
    public class Border
    {
        public void MakeBorder()
        {
            Clear();
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 1; i < WindowWidth; i++)
            {
                SetCursorPosition(i, WindowTop);
                Write("\u2550");
            }
            Thread.Sleep(1);
            for (int i = 1; i < WindowWidth; i++)
            {
                SetCursorPosition(i, WindowTop + WindowHeight - 1);
                Write("\u2550");
            }
            Thread.Sleep(1);
            for (int i = 1; i < WindowHeight - 1; i++)
            {
                SetCursorPosition(1, i);
                Write("\u2551");
            }
            Thread.Sleep(1);
            for (int i = 1; i < WindowHeight - 1; i++)
            {
                SetCursorPosition(WindowWidth - 1, i);
                Write("\u2551");
            }
            Thread.Sleep(1);
        }
    }
}
