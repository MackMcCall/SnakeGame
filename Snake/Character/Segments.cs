using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.Character
{
    public class Segments
    {
        public int xPos;
        public int yPos;

        public Segments(int x, int y)
        {
            xPos = x;
            yPos = y;
        }

        public void MoveSegment(Segments segment)
        {
            xPos = segment.xPos;
            yPos = segment.yPos;
        }

        public void MoveHead(Directions direction)
        {
            switch (direction)
            {
                case Directions.Up:
                    yPos--;
                    break;
                case Directions.Down:
                    yPos++;
                    break;
                case Directions.Right:
                    xPos++;
                    break;
                case Directions.Left:
                    xPos--;
                    break;
            }
        }
    }
}
