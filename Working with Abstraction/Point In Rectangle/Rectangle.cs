using System;
using System.Collections.Generic;
using System.Text;

namespace Point_In_Rectangle
{
    public class Rectangle
    {
        private Point topLeft;
        private Point bottomRight;

        public Rectangle(Point topLeft, Point bottomRight)
        {
            this.TopLeft = topLeft;
            this.BottomRight = bottomRight;
        }

        public Point TopLeft { get => this.topLeft; set => this.topLeft = value; }
        public Point BottomRight { get => this.bottomRight; set => this.bottomRight = value; }

        public bool Contains(Point point)
        {
            bool isHorizontal = this.TopLeft.X <= point.X &&
                this.BottomRight.X >= point.X;

            bool isVertical = this.TopLeft.Y <= point.Y &&
                this.BottomRight.Y >= point.Y;

            bool isInRectangle = isHorizontal && isVertical;

            return isInRectangle;
        }
    }
}
