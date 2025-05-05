using DiGi.VoTT.Classes;
using DiGi.VoTT.Enums;

namespace DiGi.VoTT
{
    public static partial class Query
    {
        public static AssetState? AssetState(this Asset asset)
        {
            return (AssetState?)asset?.state;
        }
    }
}

