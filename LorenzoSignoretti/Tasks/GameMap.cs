using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    public class GameMap : BaseEntity
    {
        public List<Block> Blocks { get; set; }
        public GameMap() : base(new Point2D(), true)
        {
            Blocks = new List<Block>();
        }
        public void AddBlock(Block block)
        {
            Blocks.Add(block);
        }
        public void AddBlocks(List<Block> blocks)
        {
            Blocks.AddRange(blocks);
        }

    }
}
