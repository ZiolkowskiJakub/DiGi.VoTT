using System.Collections.Generic;

namespace DiGi.VoTT.Classes
{
    /// <summary>Represents the data associated with an asset, including its related regions and version information.</summary>
    public class AssetData
    {
        /// <summary>Gets or sets the asset associated with the asset data.</summary>
        public Asset? asset { get; set; }
        /// <summary>Gets or sets the list of regions associated with the asset data.</summary>
        public List<Region> regions { get; set; } = [];
        /// <summary>Gets or sets the version identifier for the asset data.</summary>
        public string version { get; set; } = Constants.Core.Version;
    }
}
