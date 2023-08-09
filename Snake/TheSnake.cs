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
        private List<Segments> _bodySegments;

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

        public void UpdateBodyPositions(Directions directionToMove)
        {
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
        }

        public void Move(ConsoleKeyInfo keyInfo)
        {
            //while (true)
            //{
                switch (keyInfo.Key)
                {
                    case ConsoleKey.LeftArrow:
                        UpdateBodyPositions(Directions.Left);
                        Thread.Sleep(100);
                        break;
                    case ConsoleKey.RightArrow:
                        UpdateBodyPositions(Directions.Right);
                        Thread.Sleep(100);
                        break;
                    case ConsoleKey.UpArrow:
                        UpdateBodyPositions(Directions.Up);
                        Thread.Sleep(160);
                        break;
                    case ConsoleKey.DownArrow:
                        UpdateBodyPositions(Directions.Down);
                        Thread.Sleep(160);
                        break;
                    default:
                        return;
                }
                foreach (var segment in _bodySegments)
                {
                    Printing.PrintSegment(segment.xPos, segment.yPos);
                }
            //}
        }

    }
}
