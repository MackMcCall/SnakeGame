using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Snake
{
    public static class GameOver
    {
        public static void Lose(int x, int y, Border border)
        {
            Clear();
            Thread.Sleep(100);
            border.MakeBorder();

            SetCursorPosition(x - 4, y - 2);
            Write("GAME OVER");

            SetCursorPosition(x - 4, y);
            Write($"Score: {Score.CurrentScore}");

            ReadKey();
        }
    }
}
