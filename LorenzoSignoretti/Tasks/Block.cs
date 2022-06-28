namespace Tasks
{
    /// <summary>
    /// Model for every block. 
    /// Extends <see cref="BaseEntity"/>
    /// </summary>
    public class Block : GameObject
    {
        /// <summary>
        /// The Block's <see cref="IBaseEvent"/> .
        /// </summary>
        public IBaseEvent Event { get; set; }

        /// <summary>
        /// Create a Block.
        /// </summary>
        /// <param name="position">the <see cref="Point2D"/> where the block is</param>
        /// <param name="isDrawable">set if the block will be drawn</param>
        /// <param name="type">the <see cref="BaseObjectEnum"/> type of block</param>
        /// <param name="event">the <see cref="IBaseEvent"/> to set in the block</param>
        public Block(Point2D position, bool isDrawable, BaseObjectEnum type, IBaseEvent @event) : base(position, isDrawable, type)
        {
            Event = @event;
        }



    }
}
