using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Snake
{
    public class Movement
    {
        

        public ConsoleKeyInfo MonitorInput(ConsoleKeyInfo currentKey)
        {
            if (KeyAvailable)
            {
                ConsoleKeyInfo breakKey = Console.ReadKey(intercept: true);

                if (breakKey != currentKey)
                {
                    return breakKey;
                }
                else
                    return currentKey;
            }
            else
                return currentKey;
        }

        public void Move(int x, int y, ConsoleKeyInfo keyInfo)
        {
            while (true)
            {
                keyInfo = MonitorInput(keyInfo);
                switch (keyInfo.Key)
                {
                    case ConsoleKey.LeftArrow:
                        Printing.PrintSegment(x, y);
                        ;
                        Thread.Sleep(100);
                        break;
                    case ConsoleKey.RightArrow:
                        Printing.PrintSegment(x, y);
                        x++;
                        Thread.Sleep(100);
                        break;
                    case ConsoleKey.UpArrow:
                        Printing.PrintSegment(x, y);
                        y--;
                        Thread.Sleep(160);
                        break;
                    case ConsoleKey.DownArrow:
                        Printing.PrintSegment(x, y);
                        y++;
                        Thread.Sleep(160);
                        break;
                    default:
                        return;
                }
            }
        }
    }
}
