namespace Tasks
{
    /// <summary>
    /// Represent a map of game.
    /// Extends <see cref="BaseEntity"/>
    /// </summary>
    public class GameMap : BaseEntity
    {
        /// <summary>
        /// GameMaps's <see cref="Block"/>s
        /// </summary>
        public List<Block> Blocks { get; set; }

        /// <summary>
        /// Create a map.
        /// </summary>
        public GameMap() : base(new Point2D(), true)
        {
            Blocks = new List<Block>();
        }

        /// <summary>
        /// Add a <see cref="Block"/> in the map.
        /// </summary>
        /// <param name="block">the <see cref="Block"/> to add in the map</param>
        public void AddBlock(Block block)
        {
            Blocks.Add(block);
        }

        /// <summary>
        /// Add a List of <see cref="Block"/> in the map.
        /// </summary>
        /// <param name="blocks">the List of <see cref="Block"/> to add in the map</param>
        public void AddBlocks(List<Block> blocks)
        {
            Blocks.AddRange(blocks);
        }

    }
}
