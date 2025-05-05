using DiGi.VoTT.Classes;
using DiGi.VoTT.Enums;

namespace DiGi.VoTT
{
    public static partial class Query
    {
        public static AssetType? AssetType(this Asset asset)
        {
            return (AssetType?)asset?.state;
        }
    }
}

