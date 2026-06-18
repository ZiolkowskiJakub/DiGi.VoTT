using System;

namespace DiGi.VoTT.Classes
{
    /// <summary>
    /// Represents a digital asset and its associated metadata, including identification, location, and properties.
    /// </summary>
    public class Asset
    {
        /// <summary>
        /// Gets or sets the format of the asset.
        /// </summary>
        public string? format { get; set; }
        /// <summary>
        /// Gets or sets the unique identifier of the asset.
        /// </summary>
        public string id { get; set; } = Guid.NewGuid().ToString("N");
        /// <summary>
        /// Gets or sets the name of the asset.
        /// </summary>
        public string? name { get; set; }
        /// <summary>
        /// Gets or sets the path to the asset.
        /// </summary>
        public string? path { get; set; }
        /// <summary>
        /// Gets or sets the size of the asset.
        /// </summary>
        public Size? size { get; set; }
        /// <summary>
        /// Gets or sets the type of the asset.
        /// </summary>
        public short type { get; set; }
        /// <summary>
        /// Gets or sets the current state of the asset.
        /// </summary>
        public short state { get; set; }
    }
}
