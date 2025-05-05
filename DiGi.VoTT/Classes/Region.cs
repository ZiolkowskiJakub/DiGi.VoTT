using System;
using System.Collections.Generic;

namespace DiGi.VoTT.Classes
{
    public class Region
    {
        public string id { get; set; } = Guid.NewGuid().ToString("N");
        public string type { get; set; } = Constans.Region.Type.Rectangle;
        public string tagName { get; set; }
        public BoundingBox boundingBox { get; set; }
        public List<Point> points { get; set; }
    }
}
