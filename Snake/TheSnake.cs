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
        public List<Segments> _bodySegments;
        public double _speedIncrement = 1.0;
        public TheSnake()
        {
            _bodySegments = GenerateSegments();
        }
        public TheSnake(List<Segments> segments)
        {
            _bodySegments = segments;
        }

        public List<Segments> GenerateSegments()
        {
            return new List<Segments>()
            {
                new Segments(WindowWidth / 2, WindowHeight / 2),
                new Segments(WindowWidth / 2, WindowHeight / 2 - 1),
                new Segments(WindowWidth / 2, WindowHeight / 2 - 2),
            };
        }

        public void UpdateBodyPositions(Directions directionToMove)
        {
            var tailXPos = _bodySegments.Last().xPos;
            var tailYPos = _bodySegments.Last().yPos;


            
            for (int i = _bodySegments.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    _bodySegments[i].MoveHead(directionToMove);
                }
                else
                {
                    _bodySegments[i].MoveSegment(_bodySegments[i - 1]);
                }
            }
            foreach (var segment in _bodySegments)
            {
                Printing.PrintSegment(segment.xPos, segment.yPos);
            }
            SetCursorPosition(tailXPos, tailYPos);
            Write(' ');
        }

        public void PlayGame(ConsoleKeyInfo keyInfo, Fruit f, int x, int y, Border b)
        {
            while (true)
            {
                //Moving
                keyInfo = IInput.MonitorInput(keyInfo);
                switch (keyInfo.Key)
                {
                    case ConsoleKey.LeftArrow:
                        UpdateBodyPositions(Directions.Left);
                        Thread.Sleep(Convert.ToInt16(130 * _speedIncrement));
                        break;
                    case ConsoleKey.RightArrow:
                        UpdateBodyPositions(Directions.Right);
                        Thread.Sleep(Convert.ToInt16(130 * _speedIncrement));
                        break;
                    case ConsoleKey.UpArrow:
                        UpdateBodyPositions(Directions.Up);
                        Thread.Sleep(Convert.ToInt16(210 * _speedIncrement));
                        break;
                    case ConsoleKey.DownArrow:
                        UpdateBodyPositions(Directions.Down);
                        Thread.Sleep(Convert.ToInt16(210 * _speedIncrement));
                        break;
                    default:
                        return;
                }
                

                //Eating the fruit
                if (_bodySegments[0].xPos == f.FruitX && _bodySegments[0].yPos == f.FruitY)
                {
                    Segments freshSeg = new Segments(_bodySegments[_bodySegments.Count - 1].xPos, _bodySegments[_bodySegments.Count - 1].yPos);
                    _bodySegments.Add(freshSeg);
                    _speedIncrement -= .03;
                    f.NewFruit(this);
                }
                

                //Hitting the wall
                if (_bodySegments[0].xPos == 1 || _bodySegments[0].xPos == WindowWidth - 1
                    || _bodySegments[0].yPos == WindowTop || _bodySegments[0].yPos == WindowHeight - 1)
                {
                    GameOver.Lose(x, y, b);
                }
                

                //Overlapping
                bool isOverlapping = _bodySegments.Any(segment => segment != _bodySegments[0] && segment != _bodySegments[1] &&
                segment.xPos == _bodySegments[0].xPos && segment.yPos == _bodySegments[0].yPos);

                if (isOverlapping)
                {
                    GameOver.Lose(x, y, b);
                }
            }
        }

    }
}
