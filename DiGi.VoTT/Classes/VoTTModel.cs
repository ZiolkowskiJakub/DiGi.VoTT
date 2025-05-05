using System;
using System.Collections.Generic;

namespace DiGi.VoTT.Classes
{
    public class VoTTModel
    {
        public string id { get; set; } = Guid.NewGuid().ToString();
        public string name { get; set; } = string.Empty;
        public string securityToken { get; set; } = Guid.NewGuid().ToString();
        public string description { get; set; } = string.Empty;
        public string format { get; set; } = Constans.VoTTModel.Format;
        public string version { get; set; } = Constans.Core.Version;
        public List<string> tags { get; set; }
        public Dictionary<string, Asset> assets { get; set; }
    }
}
