using System;
using System.Collections.Generic;

namespace DiGi.VoTT.Classes
{
    public class Asset
    {
        public string format { get; set; }
        public string id { get; set; } = Guid.NewGuid().ToString("N");
        public string name { get; set; }
        public string path { get; set; }
        public Size size { get; set; }
        public short type { get; set; }
        public short state { get; set; }
        public List<Region> regions { get; set; }
        public string version { get; set; } = Constans.Core.Version;
    }
}
