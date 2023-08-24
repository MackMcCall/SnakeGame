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
    }
}
