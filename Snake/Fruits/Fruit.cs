using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Snake.Character;
using static System.Console;

namespace Snake.Fruits
{
    public class Fruit
    {

        private Random _random = new Random();
        public int FruitX;
        public int FruitY;

        public Fruit()
        {

        }

        public void SpawnFruitBasedOnSnakeLocation(ISnake snake)
        {
            FruitX = _random.Next(2, 47);
            FruitY = _random.Next(1, 19);
            foreach (var seg in snake.BodySegments)
            {
                if (FruitX == seg.xPos && FruitY == seg.yPos)
                {
                    SpawnFruitBasedOnSnakeLocation(snake);
                    return;
                }
            }
            Score.IncreaseScore();
            SetCursorPosition(FruitX, FruitY);
            Write("ò");
        }
    }
}
