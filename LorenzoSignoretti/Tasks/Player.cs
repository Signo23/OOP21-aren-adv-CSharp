using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    public class Player : BaseEntity
    {
        public bool IsIdle { get; set; }
        public Direction LastDirection { get; set; }
        public List<GameObject> BackPack { get; set; }
        public Player(Point2D position, bool isDrawable, bool isIdle) : base(position, isDrawable)
        {
            IsIdle = isIdle;
            LastDirection = Direction.Down;
            BackPack = new List<GameObject>();
        }
    }
}
