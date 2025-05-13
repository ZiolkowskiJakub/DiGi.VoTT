using System;
using System.Collections.Generic;

namespace DiGi.VoTT.Classes
{
    public class Region
    {
        public string id { get; set; } = Guid.NewGuid().ToString("N");
        public string type { get; set; } = Constans.Region.Type.Rectangle;
        public List<string> tags { get; set; } = new List<string>();
        public BoundingBox boundingBox { get; set; }
        public List<Point> points { get; set; } = new List<Point>();
    }
}
