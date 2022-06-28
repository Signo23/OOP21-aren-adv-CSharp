namespace Tasks
{
    /// <summary>
    /// Model for the player.
    /// Extends <see cref="BaseEntity"/>
    /// </summary>
    public class Player : BaseEntity
    {
        /// <summary>
        /// Represent if player is idle.
        /// </summary>
        public bool IsIdle { get; set; }
        /// <summary>
        /// Player's last direction
        /// </summary>
        public Direction LastDirection { get; set;
        /// <summary>
        /// Player's backpack
        /// </summary>
        public List<GameObject> BackPack { get; set; }

        /// <summary>
        /// Create a player.
        /// </summary>
        /// <param name="position">the <see cref="Point2D"/> where the player is</param>
        public Player(Point2D position) : base(position, true)
        {
            IsIdle = true;
            LastDirection = Direction.Down;
            BackPack = new List<GameObject>();
        }
    }
}
