using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Border
    {
        public void MakeBorder()
        {
            Console.Clear();
            for (int i = 1; i < Console.WindowWidth; i++)
            {
                Console.SetCursorPosition(i, Console.WindowTop);
                Console.Write("-");
            }
            for (int i = 1; i < Console.WindowWidth; i++)
            {
                Console.SetCursorPosition(i, (Console.WindowTop + Console.WindowHeight - 1));
                Console.Write("-");
            }
            for (int i = 1; i < Console.WindowHeight - 1; i++)
            {
                Console.SetCursorPosition(1, i);
                Console.Write("|");
            }
            for (int i = 1; i < Console.WindowHeight - 1; i++)
            {
                Console.SetCursorPosition(Console.WindowWidth - 1, i );
                Console.Write("|");
            }
        }
    }
}
