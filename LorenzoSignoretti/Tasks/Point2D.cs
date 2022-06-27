using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    public class Point2D
    {
        public float x { get; set; }
        public float y { get; set; }

        public Point2D(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public Point2D() : this(0, 0)
        {

        }

        public override bool Equals(object? obj) => obj is Point2D d &&
                   x == d.x &&
                   y == d.y;

        public override int GetHashCode() => HashCode.Combine(x, y);

        public override string? ToString() => "Point2D [x=" + x + ", y=" + y + "]";
    }
}
