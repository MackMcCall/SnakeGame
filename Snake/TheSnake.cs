using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Snake
{
    public class TheSnake : Movement
    {
        List<(int X, int Y)> BodyPosition = new List<(int X, int Y)>();

        public TheSnake()
        {
            
        }

        public TheSnake(int x, int y)
        {
            BodyPosition = new List<(int X, int Y)>()
            {
                (x, y)
            };
        }
    }
}
