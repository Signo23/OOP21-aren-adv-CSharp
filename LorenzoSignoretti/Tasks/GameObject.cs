using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    public class GameObject : BaseEntity
    {
        BaseObjectEnum Type { get; }
        public GameObject(Point2D position, bool isDrawable, BaseObjectEnum type) : base(position, isDrawable)
        {
            this.Type = type;
        }

        public override string? ToString()
        {
            return "GameObject [type=" + Type + "]";
        }
    }
}
