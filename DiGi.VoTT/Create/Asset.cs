using DiGi.VoTT.Classes;

namespace DiGi.VoTT
{
    public static partial class Create
    {
        public static Asset Asset(string asset)
        {
            if(asset == null)
            {
                return null;
            }

            Asset result = new Asset()
            {
                asset = asset,
            };

            return result;
        }
    }
}

