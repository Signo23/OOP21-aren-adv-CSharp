using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    public class BaseEntity
    {
        public Point2D Position { get; set; }
        public bool IsDrawable { get; set; }
        public Rectangle HitBox { get; set; }

        public BaseEntity(Point2D position, bool isDrawable)
        {
            Position = position;
            IsDrawable = isDrawable;
            HitBox = new Rectangle((int)Position.x, (int)Position.y, 32, 32);
        }
    }
}
