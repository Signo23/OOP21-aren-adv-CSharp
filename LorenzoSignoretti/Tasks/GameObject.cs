namespace Tasks
{
    /// <summary>
    /// Model for game object.
    /// Extends <see cref="BaseEntity"/>
    /// </summary>
    public class GameObject : BaseEntity
    {
        /// <summary>
        /// GameObject's type.
        /// </summary>
        BaseObjectEnum Type { get; }

        /// <summary>
        /// Create a GameObject.
        /// </summary>
        /// <param name="position">the <see cref="Point2D"/> where to draw the GameObject</param>
        /// <param name="isDrawable">if GameObject is drawable</param>
        /// <param name="type"> <see cref="BaseObjectEnum"/> type of GameObject</param>
        public GameObject(Point2D position, bool isDrawable, BaseObjectEnum type) : base(position, isDrawable)
        {
            Type = type;
        }

        public override string? ToString()
        {
            return "GameObject [type=" + Type + "]";
        }
    }
}
