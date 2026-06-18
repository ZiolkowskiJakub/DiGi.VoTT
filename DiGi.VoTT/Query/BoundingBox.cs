using DiGi.VoTT.Classes;
using System.Collections.Generic;

namespace DiGi.VoTT
{
    public static partial class Query
    {
        /// <summary>
        /// Calculates the four corner points of the specified bounding box.
        /// </summary>
        /// <param name="boundingBox">The <see cref="BoundingBox"/> instance to convert into a list of points.</param>
        /// <returns>A <see cref="List{Point}"/> containing the corners of the bounding box, or <c>null</c> if the provided bounding box is null.</returns>
        public static List<Point>? Points(this BoundingBox? boundingBox)
        {
            if (boundingBox == null)
            {
                return null;
            }

            List<Point> result =
            [
                new Point(boundingBox.left, boundingBox.top),
                new Point(boundingBox.left + boundingBox.width, boundingBox.top),
                new Point(boundingBox.left + boundingBox.width, boundingBox.top + boundingBox.height),
                new Point(boundingBox.left, boundingBox.top + boundingBox.height),
            ];

            return result;
        }
    }
}
