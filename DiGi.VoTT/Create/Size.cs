using System.Drawing;

namespace DiGi.VoTT
{
    public static partial class Create
    {
        /// <summary>
        /// Retrieves the dimensions of an image file located at the specified path.
        /// </summary>
        /// <param name="path">The file system path to the image.</param>
        /// <returns>A <see cref="Classes.Size"/> object containing the width and height if the file exists; otherwise, null.</returns>
        public static Classes.Size? Size(string? path)
        {
            if (string.IsNullOrWhiteSpace(path) || !System.IO.File.Exists(path))
            {
                return null;
            }

            Classes.Size? result = null;

            using (Bitmap bitmap = new(path!))
            {
                result = new Classes.Size(bitmap.Width, bitmap.Height);
            }

            return result;
        }
    }
}
