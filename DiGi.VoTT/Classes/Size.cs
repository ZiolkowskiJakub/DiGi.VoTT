namespace DiGi.VoTT.Classes
{
    /// <summary>
    /// Represents the dimensions of an object, consisting of width and height values.
    /// </summary>
    public class Size
    {
        /// <summary>
        /// Gets or sets the width value of the size.
        /// </summary>
        public float width { get; set; }
        /// <summary>
        /// Gets or sets the height value of the size.
        /// </summary>
        public float height { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Size"/> class with the specified width and height.
        /// </summary>
        /// <param name="width">The width value to assign to the instance.</param>
        /// <param name="height">The height value to assign to the instance.</param>
        public Size(float width, float height)
        {
            this.width = width;
            this.height = height;
        }
    }
}
