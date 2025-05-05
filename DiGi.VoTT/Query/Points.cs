using DiGi.VoTT.Classes;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.VoTT
{
    public static partial class Query
    {
        public static BoundingBox BoundingBox(this IEnumerable<Point> points)
        {
            if (points == null || points.Count() < 2)
            {
                return null;
            }

            float width_min = float.NaN;
            float height_min = float.NaN;
            float width_max = float.NaN;
            float height_max = float.NaN;

            foreach (Point point in points) 
            {
                if(point == null)
                {
                    continue;
                }

                if(float.IsNaN(width_min) || point.x < width_min)
                {
                    width_min = point.x;
                }

                if (float.IsNaN(width_max) || point.x > width_max)
                {
                    width_max = point.x;
                }

                if (float.IsNaN(height_min) || point.y < height_min)
                {
                    height_min = point.y;
                }

                if (float.IsNaN(height_max) || point.y > height_max)
                {
                    height_max = point.y;
                }
            }

            if(float.IsNaN(width_min) || float.IsNaN(height_min) || float.IsNaN(width_max) || float.IsNaN(height_max))
            {
                return null;
            }

            return new BoundingBox() 
            {
                left = width_min,
                top = height_max,
                width = width_max - width_min,
                height = height_max - height_min
            };
        }
    }
}

