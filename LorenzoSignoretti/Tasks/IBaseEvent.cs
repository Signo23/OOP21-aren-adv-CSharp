using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    public interface IBaseEvent
    {
        void Launch(Player player);
        bool isAlreadyLunch();
    }
}
