namespace Tasks
{
    /// <summary>
    /// Direction's enum.
    /// </summary>
    public enum Direction
    {
        /// <summary>
        /// Up's direction.
        /// </summary>
        Up,
        /// <summary>
        /// Down's direction.
        /// </summary>
        Down,
        /// <summary>
        /// Left's direction.
        /// </summary>
        Left,
        /// <summary>
        /// Right's direction.
        /// </summary>
        Right
    }

    /// <summary>
    /// Direction's vector.
    /// </summary>
    public static class Directions
    {
        /// <summary>
        /// Get the vector of direction.
        /// </summary>
        /// <param name="direction"> the <see cref="Direction"/> to get</param>
        /// <returns>a <see cref="Point2D"/> representing the vector</returns>
        public static Point2D GetVector(this Direction direction)
        {
            return direction switch
            {
                Direction.Up => new Point2D(0, -1),
                Direction.Down => new Point2D(0, 1),
                Direction.Left => new Point2D(-1, 0),
                Direction.Right => new Point2D(1, 0),
                _ => new Point2D(0, 0),
            };
        }
    }
}
