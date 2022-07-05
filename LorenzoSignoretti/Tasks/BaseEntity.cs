using System.Drawing;

namespace Tasks
{
    /// <summary>
    /// Class <c>BaseEntity</c> models a base entity.
    /// </summary>
    public class BaseEntity
    {
        /// <summary>
        /// <c>BaseEntity</c>'s position.
        /// </summary>
        public Point2D Position { get; set; }

        /// <summary>
        /// Represent if the <c>BaseEntity</c> is drawable.
        /// </summary>
        public bool IsDrawable { get; set; }

        /// <summary>
        /// Represent <c>BaseEntity</c>'s hit box.
        /// </summary>
        public Rectangle HitBox { get; set; }

        /// <summary>
        /// Create an Entity.
        /// </summary>
        /// <param name="position">where position have to be set</param>
        /// <param name="isDrawable">set if the block will be drawn</param>
        public BaseEntity(Point2D position, bool isDrawable)
        {
            Position = position;
            IsDrawable = isDrawable;
            HitBox = new Rectangle((int)Position.X, (int)Position.Y, 32, 32);
        }
    }
}
