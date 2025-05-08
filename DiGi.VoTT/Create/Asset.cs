using DiGi.VoTT.Classes;
using System.Net;

namespace DiGi.VoTT
{
    public static partial class Create
    {
        public static Asset Asset_ById(string id)
        {
            if (id == null)
            {
                return null;
            }

            Asset result = new Asset()
            {
                id = id,
            };

            return result;
        }

        public static Asset Asset(string path)
        {
            if (string.IsNullOrWhiteSpace(path) || !System.IO.File.Exists(path))
            {
                return null;
            }

            Asset result = new Asset()
            {
                format = System.IO.Path.GetExtension(path).Substring(1),
                name = System.IO.Path.GetFileName(path),
                path = string.Format("file:{0}", path.Replace(" ", "%20").Replace(@"\", "/")),
                size = Size(path),
                state = (short)Enums.AssetState.NotVisited,
                type = (short)Enums.AssetType.Image,
            };

            return result;
        }
    }
}

