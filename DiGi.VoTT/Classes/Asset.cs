using System;

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
    }
}
