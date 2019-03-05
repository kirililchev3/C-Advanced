using System;
using System.Collections.Generic;
using System.Text;

namespace Point_In_Rectangle
{
    public class Point
    {
        private int x;
        private int y;

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public int X { get => this.x; set => this.x = value; }
        public int Y { get => this.y; set =>this.y = value; }
    }
}
