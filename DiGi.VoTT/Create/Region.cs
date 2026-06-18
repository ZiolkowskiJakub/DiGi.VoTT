using DiGi.VoTT.Classes;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.VoTT
{
    public static partial class Create
    {
        /// <summary>
        /// Creates a <see cref="DiGi.VoTT.Classes.Region"/> object by defining a bounding box with the specified coordinates and associating it with a tag name.
        /// </summary>
        /// <param name="x_1">The X-coordinate of the first point of the bounding box.</param>
        /// <param name="y_1">The Y-coordinate of the first point of the bounding box.</param>
        /// <param name="x_2">The X-coordinate of the second point of the bounding box.</param>
        /// <param name="y_2">The Y-coordinate of the second point of the bounding box.</param>
        /// <param name="tagName">The name of the tag to associate with the created region.</param>
        /// <returns>A new <see cref="DiGi.VoTT.Classes.Region"/> instance if a valid bounding box is created and the tag name is provided; otherwise, <c>null</c>.</returns>
        public static Region? Region(double x_1, double y_1, double x_2, double y_2, string tagName)
        {
            return Region(BoundingBox(x_1, y_1, x_2, y_2), tagName);
        }

        /// <summary>
        /// Creates a <see cref="DiGi.VoTT.Classes.Region"/> object from a bounding box and a tag name.
        /// </summary>
        /// <param name="boundingBox">The <see cref="BoundingBox"/> that defines the region's boundaries.</param>
        /// <param name="tagName">The name of the tag to associate with the created region.</param>
        /// <returns>A new <see cref="DiGi.VoTT.Classes.Region"/> instance if the bounding box is not null and the tag name is provided; otherwise, <c>null</c>.</returns>
        public static Region? Region(this BoundingBox? boundingBox, string tagName)
        {
            if (boundingBox == null || string.IsNullOrWhiteSpace(tagName))
            {
                return null;
            }

            Region result = new()
            {
                type = Constants.Region.Type.Rectangle,
                tags = [tagName],
                boundingBox = boundingBox,
                points = Query.Points(boundingBox) ?? [],
            };

            return result;
        }

        /// <summary>
        /// Creates a <see cref="DiGi.VoTT.Classes.Region"/> object from a collection of points and a tag name.
        /// </summary>
        /// <param name="points">The collection of <see cref="Point"/> objects that define the region's boundary.</param>
        /// <param name="tagName">The name of the tag to associate with the created region.</param>
        /// <returns>A new <see cref="DiGi.VoTT.Classes.Region"/> instance if the points are not null, contain at least three elements, and the tag name is provided; otherwise, <c>null</c>.</returns>
        public static Region? Region(this IEnumerable<Point>? points, string? tagName)
        {
            if (points == null || points.Count() < 3 || string.IsNullOrWhiteSpace(tagName))
            {
                return null;
            }

            Region result = new()
            {
                type = Constants.Region.Type.Polygon,
                tags = tagName == null ? [] : [tagName],
                boundingBox = Query.BoundingBox(points),
                points = [.. points],
            };

            return result;
        }
    }
}
