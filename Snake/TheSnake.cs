﻿using System;
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

        public void Move(ConsoleKeyInfo keyInfo, Fruit f)
        {
            while (true)
            {
                keyInfo = MonitorInput(keyInfo);
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
                        Thread.Sleep(170);
                        break;
                    case ConsoleKey.DownArrow:
                        UpdateBodyPositions(Directions.Down);
                        Thread.Sleep(170);
                        break;
                    default:
                        return;
                }
                
                //eating the fruit
                if (_bodySegments[0].xPos == f.FruitX && _bodySegments[0].yPos == f.FruitY)
                {
                    f.NewFruit();
                    Segments freshSeg = new Segments(_bodySegments[_bodySegments.Count - 1].xPos, _bodySegments[_bodySegments.Count - 1].yPos);
                    _bodySegments.Add(freshSeg);
                }
                
                //hitting the wall
                if (_bodySegments[0].xPos == 1 || _bodySegments[0].xPos == WindowWidth - 1
                    || _bodySegments[0].yPos == WindowTop || _bodySegments[0].yPos == WindowHeight - 1)
                {
                    throw new ArgumentOutOfRangeException();
                }
                
                //overlapping
                bool isOverlapping = _bodySegments.Any(segment => segment != _bodySegments[0] && segment != _bodySegments[1] &&
                segment.xPos == _bodySegments[0].xPos && segment.yPos == _bodySegments[0].yPos);

                if (isOverlapping)
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

    }
}
