using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class TheSnake
    {
        public int x;
        public int y;
        public string xDir;
        public string yDir;

        ConsoleKeyInfo keyInfo = Console.ReadKey();
        
        public void Move(int x, int y, ConsoleKeyInfo keyInfo)
        {
            switch (keyInfo.Key)
            {
                case (ConsoleKey.LeftArrow):
                    //Console.Clear();
                    Console.SetCursorPosition(x, y);
                    Console.Write("#");
                    x--;
                    Thread.Sleep(100);

                    if (Console.KeyAvailable)
                    {
                        ConsoleKeyInfo breakKey = Console.ReadKey(intercept: true);

                        if (breakKey.Key != ConsoleKey.LeftArrow)
                        {
                            keyInfo = breakKey;
                        }
                    }
                    break;
            }




            //while (keyInfo.Key == ConsoleKey.LeftArrow && x > 2)
            //{
            //    //Console.Clear();
            //    Console.SetCursorPosition(x, y);
            //    Console.Write("#");
            //    x--;
            //    Thread.Sleep(100);

            //    if (Console.KeyAvailable)
            //    {
            //        ConsoleKeyInfo breakKey = Console.ReadKey(intercept: true);

            //        if (breakKey.Key != ConsoleKey.LeftArrow)
            //        {
            //            keyInfo = breakKey;
            //        }
            //    }
            //}
            //while (keyInfo.Key == ConsoleKey.RightArrow && x < Console.WindowWidth - 3)
            //{
            //    //Console.Clear();
            //    Console.SetCursorPosition(x, y);
            //    Console.Write("#");
            //    x++;
            //    Thread.Sleep(100);

            //    if (Console.KeyAvailable)
            //    {
            //        ConsoleKeyInfo breakKey = Console.ReadKey(intercept: true);

            //        if (breakKey.Key != ConsoleKey.RightArrow)
            //        {
            //            keyInfo = breakKey;
            //        }
            //    }
            //}
            //while (keyInfo.Key == ConsoleKey.UpArrow && y > 1)
            //{
            //    //Console.Clear();
            //    Console.SetCursorPosition(x, y);
            //    Console.Write("#");
            //    y--;
            //    Thread.Sleep(150);

            //    if (Console.KeyAvailable)
            //    {
            //        ConsoleKeyInfo breakKey = Console.ReadKey(intercept: true);

            //        if (breakKey.Key != ConsoleKey.UpArrow)
            //        {
            //            keyInfo = breakKey;
            //        }
            //    }
            //}
            //while (keyInfo.Key == ConsoleKey.DownArrow && y < Console.WindowHeight - 2)
            //{
            //    //Console.Clear();
            //    Console.SetCursorPosition(x, y);
            //    Console.Write("#");
            //    y++;
            //    Thread.Sleep(150);

            //    if (Console.KeyAvailable)
            //    {
            //        ConsoleKeyInfo breakKey = Console.ReadKey(intercept: true);

            //        if (breakKey.Key != ConsoleKey.DownArrow)
            //        {
            //            keyInfo = breakKey;
            //        }
            //    }
            //}
        }

    }
}
