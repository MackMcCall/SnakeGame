using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Snake
{
    public static class PlayGame
    {
        public static void Play(ConsoleKeyInfo keyInfo, TheSnake s, Fruit f, int x, int y, Border b)
        {
            while (true)
            {
                //Moving
                keyInfo = IInput.MonitorInput(keyInfo);
                switch (keyInfo.Key)
                {
                    case ConsoleKey.LeftArrow:
                        s.UpdateBodyPositions(Directions.Left);
                        Thread.Sleep(Convert.ToInt16(130 * s._speedIncrement));
                        break;
                    case ConsoleKey.RightArrow:
                        s.UpdateBodyPositions(Directions.Right);
                        Thread.Sleep(Convert.ToInt16(130 * s._speedIncrement));
                        break;
                    case ConsoleKey.UpArrow:
                        s.UpdateBodyPositions(Directions.Up);
                        Thread.Sleep(Convert.ToInt16(210 * s._speedIncrement));
                        break;
                    case ConsoleKey.DownArrow:
                        s.UpdateBodyPositions(Directions.Down);
                        Thread.Sleep(Convert.ToInt16(210 * s._speedIncrement));
                        break;
                    default:
                        return;
                }


                //Eating the fruit
                if (s._bodySegments[0].xPos == f.FruitX && s._bodySegments[0].yPos == f.FruitY)
                {
                    Segments freshSeg = new Segments(s._bodySegments[s._bodySegments.Count - 1].xPos, s._bodySegments[s._bodySegments.Count - 1].yPos);
                    s._bodySegments.Add(freshSeg);
                    s._speedIncrement -= .03;
                    f.NewFruit(s);
                }


                //Hitting the wall
                if (s._bodySegments[0].xPos == 1 || s._bodySegments[0].xPos == WindowWidth - 1
                    || s._bodySegments[0].yPos == WindowTop || s._bodySegments[0].yPos == WindowHeight - 1)
                {
                    GameOver.Lose(x, y, b);
                }


                //Overlapping
                bool isOverlapping = s._bodySegments.Any(segment => segment != s._bodySegments[0] && segment != s._bodySegments[1] &&
                segment.xPos == s._bodySegments[0].xPos && segment.yPos == s._bodySegments[0].yPos);

                if (isOverlapping)
                {
                    GameOver.Lose(x, y, b);
                }
            }
        }
    }
}
