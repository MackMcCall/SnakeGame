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
    }
}
