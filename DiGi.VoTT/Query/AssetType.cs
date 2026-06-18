using DiGi.VoTT.Classes;
using DiGi.VoTT.Enums;

namespace DiGi.VoTT
{
    public static partial class Query
    {
        /// <summary>
        /// Gets the asset type associated with the specified asset.
        /// </summary>
        /// <param name="asset">The <see cref="Asset"/> instance to evaluate.</param>
        /// <returns>The <see cref="AssetType"/> of the asset, or null if the asset is null.</returns>
        public static AssetType? AssetType(this Asset asset)
        {
            return (AssetType?)asset?.state;
        }
    }
}
