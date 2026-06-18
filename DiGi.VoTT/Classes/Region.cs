using System;
using System.Collections.Generic;

namespace DiGi.VoTT.Classes
{
    /// <summary>
    /// Represents a spatial region defined by a type, boundary points, and an optional bounding box.
    /// </summary>
    public class Region
    {
        /// <summary>
        /// Gets or sets the unique identifier for the region.
        /// </summary>
        public string id { get; set; } = Guid.NewGuid().ToString("N");
        /// <summary>
        /// Gets or sets the type of the region, such as a rectangle.
        /// </summary>
        public string type { get; set; } = Constants.Region.Type.Rectangle;
        /// <summary>
        /// Gets or sets the list of tags associated with the region.
        /// </summary>
        public List<string> tags { get; set; } = [];
        /// <summary>
        /// Gets or sets the bounding box that encompasses the region.
        /// </summary>
        public BoundingBox? boundingBox { get; set; }
        /// <summary>
        /// Gets or sets the list of <see cref="Point"/> objects that define the boundaries of the region.
        /// </summary>
        public List<Point> points { get; set; } = [];
    }
}
