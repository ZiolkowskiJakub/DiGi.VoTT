using System;
using System.Collections.Generic;

namespace DiGi.VoTT.Classes
{
    /// <summary>Represents a Voice-over-Text (VoTT) model containing configuration details, metadata, and associated assets.</summary>
    public class VoTTModel
    {
        /// <summary>Gets or sets the unique identifier of the VoTT model.</summary>
        public string id { get; set; } = Guid.NewGuid().ToString("N");
        /// <summary>Gets or sets the name of the VoTT model.</summary>
        public string name { get; set; } = string.Empty;
        /// <summary>Gets or sets the security token associated with the VoTT model.</summary>
        public string securityToken { get; set; } = string.Empty;
        /// <summary>Gets or sets the description of the VoTT model.</summary>
        public string description { get; set; } = string.Empty;
        /// <summary>Gets or sets the format string of the VoTT model.</summary>
        public string format { get; set; } = Constants.VoTTModel.Format;
        /// <summary>Gets or sets the version string of the VoTT model.</summary>
        public string version { get; set; } = Constants.Core.Version;
        /// <summary>Gets or sets the list of <see cref="Tag"/> objects associated with this model.</summary>
        public List<Tag>? tags { get; set; }
        /// <summary>Gets or sets the dictionary of assets, where the key is a string identifier and the value is the associated <see cref="AssetData"/>.</summary>
        public Dictionary<string, AssetData> assets { get; set; } = [];
    }
}
