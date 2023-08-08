using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Snake
{
    public class TheSnake
    {
        public int Segments = 5;
        
        public List<int> BodyListX = new List<int>(50) { WindowWidth / 2 };
        public List<int> BodyListY = new List<int>(50) { WindowHeight / 2 };

        public TheSnake()
        {

        }

        //public TheSnake()
        //{
        //    BodyList = new List<(int X, int Y)>(5)
        //    {

        //    };
        //}


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

        public void Move(ConsoleKeyInfo keyInfo)
        {
            while (true)
            {
                switch (keyInfo.Key)
                {
                    case ConsoleKey.LeftArrow:
                        BodyListX[0]--;
                        Thread.Sleep(100);
                        break;
                    case ConsoleKey.RightArrow:
                        BodyListX[0]++;
                        Thread.Sleep(100);
                        break;
                    case ConsoleKey.UpArrow:
                        BodyListY[0]--;
                        Thread.Sleep(160);
                        break;
                    case ConsoleKey.DownArrow:
                        BodyListY[0]++;
                        Thread.Sleep(160);
                        break;
                    default:
                        return;
                }
                for (int i = 0; i < Segments; i++)
                {
                    Printing.PrintSegment(BodyListX[i], BodyListY[i]);
                }
            }
        }

    }
}
