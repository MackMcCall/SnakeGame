using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Snake.Character;
using Snake.Printing;
using Snake.Fruits;
using static System.Console;

namespace Snake
{
    public static class PlayGame
    {
        public static void Play(ConsoleKeyInfo keyInfo, ISnake s, Fruit f, int x, int y, Border b)
        {
            while (true)
            {
                //Moving
                keyInfo = IInput.MonitorInput(keyInfo);
                switch (keyInfo.Key)
                {
                    case ConsoleKey.LeftArrow:
                        s.UpdateBodyPositions(Directions.Left);
                        Thread.Sleep(Convert.ToInt32(130 * s.SpeedIncrement));
                        break;
                    case ConsoleKey.RightArrow:
                        s.UpdateBodyPositions(Directions.Right);
                        Thread.Sleep(Convert.ToInt32(130 * s.SpeedIncrement));
                        break;
                    case ConsoleKey.UpArrow:
                        s.UpdateBodyPositions(Directions.Up);
                        Thread.Sleep(Convert.ToInt32(210 * (s.SpeedIncrement * 1.35)));
                        break;
                    case ConsoleKey.DownArrow:
                        s.UpdateBodyPositions(Directions.Down);
                        Thread.Sleep(Convert.ToInt32(210 * (s.SpeedIncrement * 1.35)));
                        break;
                    default:
                        return;
                }


                //Eating the fruit
                if (s.BodySegments[0].xPos == f.FruitX && s.BodySegments[0].yPos == f.FruitY)
                {
                    Segments freshSeg = new Segments(s.BodySegments[s.BodySegments.Count - 1].xPos, s.BodySegments[s.BodySegments.Count - 1].yPos);
                    s.BodySegments.Add(freshSeg);
                    if (s.SpeedIncrement > .03)
                    {
                        s.SpeedIncrement -= .03;
                    }
                    f.SpawnFruitBasedOnSnakeLocation(s);
                }


                //Hitting the wall
                if (s.BodySegments[0].xPos == 1 || s.BodySegments[0].xPos == WindowWidth - 1
                    || s.BodySegments[0].yPos == WindowTop || s.BodySegments[0].yPos == WindowHeight - 1)
                {
                    GameOver.Lose(x, y, b);
                }


                //Overlapping
                bool isOverlapping = s.BodySegments.Any(segment => segment != s.BodySegments[0] && segment != s.BodySegments[1] &&
                segment.xPos == s.BodySegments[0].xPos && segment.yPos == s.BodySegments[0].yPos);

                if (isOverlapping)
                {
                    GameOver.Lose(x, y, b);
                }
            }
        }
    }
}
