using Snake.Printing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using Snake.Printing;

namespace Snake.Character
{
    public class RedSnake : ISnake
    {
        public List<Segments> BodySegments { get; set; }
        public double SpeedIncrement { get; set; } = 1.0;

        public ConsoleColor SnakeColor { get; set; } = ConsoleColor.DarkRed;

        public RedSnake()
        {
            Console.ForegroundColor = SnakeColor;
            BodySegments = GenerateSegments();
        }
        public RedSnake(List<Segments> segments)
        {
            BodySegments = segments;
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
            var tailXPos = BodySegments.Last().xPos;
            var tailYPos = BodySegments.Last().yPos;



            for (int i = BodySegments.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    BodySegments[i].MoveHead(directionToMove);
                }
                else
                {
                    BodySegments[i].MoveSegment(BodySegments[i - 1]);
                }
            }
            foreach (var segment in BodySegments)
            {
                PrintSnake.PrintSegment(segment.xPos, segment.yPos, SnakeColor);
            }
            SetCursorPosition(tailXPos, tailYPos);
            Write(' ');
        }
    }
}
