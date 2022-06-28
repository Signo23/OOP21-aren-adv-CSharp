namespace Tasks
{
    /// <summary>
    /// A point in 2 dimension.
    /// </summary>
    public class Point2D
    {
        /// <summary>
        /// Point's x coordinate
        /// </summary>
        public float x { get; set; }
        /// <summary>
        /// Point's y coordinate
        /// </summary>
        public float y { get; set; }

        /// <summary>
        /// Create a point on x, y coordinates.
        /// </summary>
        /// <param name="x">the x coordinate</param>
        /// <param name="y">the y coordinate</param>
        public Point2D(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        /// <summary>
        /// Create a point on the origin.
        /// </summary>
        public Point2D() : this(0, 0)
        {

        }

        public override bool Equals(object? obj) => obj is Point2D d &&
                   x == d.x &&
                   y == d.y;

        public override int GetHashCode() => HashCode.Combine(x, y);

        public override string? ToString() => "Point2D [x=" + x + ", y=" + y + "]";
    }
}
