using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public enum Direction { Up, Down, Left, Right };
    class Settings
    {
        public static int Width { get; set; }
        public static int Height { get; set; }
        public static int Speed { get; set; }
        public static int Score { get; set; }
        public static int high_score { get; set; }
        public static int Points { get; set; }
        public static bool GameOver { get; set; }
        public static bool GamePause { get; set; }
        public static Direction direction { get; set; }

        public Settings()
        {
            Width = 16;
            Height = 16;
            Speed = 2;
            Score = 0;
            high_score = 0;
            Points = 1;
            GameOver = false;
            GamePause = false;
            direction = Direction.Down;
        }
    }
}
