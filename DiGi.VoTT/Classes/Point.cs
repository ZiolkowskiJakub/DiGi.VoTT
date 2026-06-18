namespace DiGi.VoTT.Classes
{
    /// <summary>
    /// Represents a point in two-dimensional space with floating-point coordinates.
    /// </summary>
    public class Point
    {
        /// <summary>
        /// Gets or sets the X-coordinate of the point.
        /// </summary>
        public float x { get; set; }
        /// <summary>
        /// Gets or sets the Y-coordinate of the point.
        /// </summary>
        public float y { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Point"/> class with the specified coordinates.
        /// </summary>
        /// <param name="x">The X-coordinate of the point.</param>
        /// <param name="y">The Y-coordinate of the point.</param>
        public Point(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
