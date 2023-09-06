using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.Character
{
    public class RedSnake : ISnake
    {
        public List<Segments> BodySegments { get; set; }
        public double SpeedIncrement { get; set; }

        public List<Segments> GenerateSegments()
        {
            throw new NotImplementedException();
        }

        public void UpdateBodyPositions(Directions directionToMove)
        {
            throw new NotImplementedException();
        }
    }
}
