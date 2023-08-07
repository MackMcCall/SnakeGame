using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Snake
{
    public class Border
    {
        public void MakeBorder()
        {
            Clear();
            for (int i = 1; i < WindowWidth; i++)
            {
                SetCursorPosition(i, WindowTop);
                Write("-");
            }
            for (int i = 1; i < WindowWidth; i++)
            {
                SetCursorPosition(i, (WindowTop + WindowHeight - 1));
                Write("-");
            }
            for (int i = 1; i < WindowHeight - 1; i++)
            {
                SetCursorPosition(1, i);
                Write("|");
            }
            for (int i = 1; i < WindowHeight - 1; i++)
            {
                SetCursorPosition(WindowWidth - 1, i );
                Write("|");
            }
        }
    }
}
