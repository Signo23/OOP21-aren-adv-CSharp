using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    public class Block : GameObject
    {

        public IBaseEvent Event { get; set; }
        public Block(Point2D position, bool isDrawable, BaseObjectEnum type, IBaseEvent @event) : base(position, isDrawable, type)
        {
            Event = @event;
        }



    }
}
