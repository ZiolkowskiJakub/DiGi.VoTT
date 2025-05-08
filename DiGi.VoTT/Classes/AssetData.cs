using System;
using System.Collections.Generic;

namespace DiGi.VoTT.Classes
{
    public class AssetData
    {
        public Asset asset { get; set; }
        public List<Region> regions { get; set; }
        public string version { get; set; } = Constans.Core.Version;
    }
}
