using DiGi.VoTT.Classes;
using DiGi.VoTT.Enums;

namespace DiGi.VoTT
{
    public static partial class Query
    {
        /// <summary>
        /// Gets the state of the specified asset as an <see cref="AssetState"/> value.
        /// </summary>
        /// <param name="asset">The <see cref="Asset"/> instance to retrieve the state from.</param>
        /// <returns>The <see cref="AssetState"/> of the asset, or null if the asset is null.</returns>
        public static AssetState? AssetState(this Asset asset)
        {
            return (AssetState?)asset?.state;
        }
    }
}
