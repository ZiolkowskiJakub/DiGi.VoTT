using DiGi.VoTT.Classes;
using System.Collections.Generic;

namespace DiGi.VoTT
{
    public static partial class Query
    {
        public static List<Point> Points(this BoundingBox boundingBox)
        {
            if (boundingBox == null)
            {
                return null;
            }

            List<Point> result = new List<Point>()
            {
                new Point(boundingBox.left, boundingBox.top),
                new Point(boundingBox.left + boundingBox.width, boundingBox.top),
                new Point(boundingBox.left + boundingBox.width, boundingBox.top + boundingBox.height),
                new Point(boundingBox.left, boundingBox.top + boundingBox.height),
            };

            return result;
        }
    }
}

