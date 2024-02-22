using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.Character
{
    public interface ISnake
    {
        List<Segments> GenerateSegments();
        void UpdateBodyPositions(Directions directionToMove);

        public List<Segments> BodySegments { get; set; }
        public double SpeedIncrement { get; set; }
    }
}
