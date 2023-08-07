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

        public Fruit(Random random)
        {
            _random = random;
        }

        public void NewFruit(int x, int y)
        {
            Random fruitX = new Random();
            Random fruitY = new Random();
            var newXPosition = _random.Next(2, 59);
            var newYPosition = _random.Next(1, 24);
        }

        public void PrintFruit(int x, int y)
        {

        }
    }
}
