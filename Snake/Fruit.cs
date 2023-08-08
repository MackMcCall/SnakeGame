using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Snake
{
    public class Fruit
    {
        
        private readonly Random _random;
        public int FruitX;
        public int FruitY;

        public Fruit(Random random)
        {
            _random = random;
        }

        public void NewFruit()
        {
            FruitX = _random.Next(2, 59);
            FruitY = _random.Next(1, 24);
            SetCursorPosition(FruitX, FruitY);
            Write("TC");
        }
    }
}
