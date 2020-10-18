using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace musicApp.Types
{
    public class Vector2
    {
        public int x;
        public int y;

        public Vector2(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Vector2(Size size)
        {
            this.x = size.Width;
            this.y = size.Height;
        }

        public Vector2(Point point)
        {
            this.x = point.X;
            this.y = point.Y;
        }
    }
}
