using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Snake
{
    public interface IInput
    {


        public static ConsoleKeyInfo MonitorInput(ConsoleKeyInfo currentKey)
        {

            if (KeyAvailable)
            {
                ConsoleKeyInfo nextKey = ReadKey(intercept: true);

                bool isNotOpposite = true;

                if (currentKey.Key == ConsoleKey.LeftArrow && nextKey.Key == ConsoleKey.RightArrow ||
                    currentKey.Key == ConsoleKey.RightArrow && nextKey.Key == ConsoleKey.LeftArrow ||
                    currentKey.Key == ConsoleKey.UpArrow && nextKey.Key == ConsoleKey.DownArrow ||
                    currentKey.Key == ConsoleKey.DownArrow && nextKey.Key == ConsoleKey.UpArrow)
                {
                    isNotOpposite = false;
                }

                if (nextKey != currentKey && isNotOpposite)
                {
                    return nextKey;
                }
                else
                    return currentKey;
            }
            else
                return currentKey;
        }
    }
}
