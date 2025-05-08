using DiGi.VoTT.Classes;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.VoTT
{
    public static partial class Create
    {
        public static Region Region(double x_1, double y_1, double x_2, double y_2, string tagName)
        {
            return Region(BoundingBox(x_1, y_1, x_2, y_2), tagName);
        }
        
        public static Region Region(this BoundingBox boundingBox, string tagName)
        {
            if(boundingBox == null || string.IsNullOrWhiteSpace(tagName))
            {
                return null;
            }

            Region result = new Region()
            {
                type = Constans.Region.Type.Rectangle,
                tags = new List<string>() { tagName },
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
                tags = new List<string>() { tagName },
                boundingBox = Query.BoundingBox(points),
                points = new List<Point>(points),
            };

            return result;
        }
    }
}

