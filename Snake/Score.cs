using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public static class Score
    {
        public static int CurrentScore { get; set; } = -100;

        public static void IncreaseScore()
        {
            CurrentScore += 100;
        }
    }
}
