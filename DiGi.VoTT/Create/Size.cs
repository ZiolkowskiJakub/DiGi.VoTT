using System.Drawing;

namespace DiGi.VoTT
{
    public static partial class Create
    {
        public static Classes.Size Size(string path)
        {
            if(string.IsNullOrWhiteSpace(path) || !System.IO.File.Exists(path))
            {
                return null;
            }

            Classes.Size result = null;

            using (Bitmap bitmap = new Bitmap(path))
            {
                result.width = bitmap.Width;
                result.height = bitmap.Height;
            }

            return result;
        }
    }
}

