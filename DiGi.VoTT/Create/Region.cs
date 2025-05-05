using DiGi.VoTT.Classes;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.VoTT
{
    public static partial class Create
    {
        public static Region Region(this BoundingBox boundingBox, string tagName)
        {
            if(boundingBox == null || string.IsNullOrWhiteSpace(tagName))
            {
                return null;
            }

            Region result = new Region()
            {
                type = Constans.Region.Type.Rectangle,
                tagName = tagName,
                boundingBox = boundingBox,
                points = Query.Points(boundingBox),
            };

            return result;
        }

        public static Region Region(this IEnumerable<Point> points, string tagName)
        {
            if (points == null || points.Count() < 3 || string.IsNullOrWhiteSpace(tagName))
            {
                return null;
            }

            Region result = new Region()
            {
                type = Constans.Region.Type.Polygon,
                tagName = tagName,
                boundingBox = Query.BoundingBox(points),
                points = new List<Point>(points),
            };

            return result;
        }
    }
}

