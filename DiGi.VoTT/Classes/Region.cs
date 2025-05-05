using System;
using System.Collections.Generic;

namespace DiGi.VoTT.Classes
{
    public class Region
    {
        public string id { get; set; } = Guid.NewGuid().ToString();
        public string type { get; set; } = Constans.Region.Type;
        public string tagName { get; set; }
        public BoundingBox boundingBox { get; set; }
        public List<Point> points { get; set; }
    }
}
