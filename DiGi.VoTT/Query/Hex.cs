namespace DiGi.VoTT
{
    public static partial class Query
    {
        /// <summary>
        /// Converts a <see cref="System.Drawing.Color"/> object to its hexadecimal string representation.
        /// </summary>
        /// <param name="color">The <see cref="System.Drawing.Color"/> instance to convert.</param>
        /// <returns>A string representing the color in hexadecimal format (e.g., "#RRGGBB").</returns>
        public static string Hex(this System.Drawing.Color color)
        {
            return $"#{color.R:X2}{color.G:X2}{color.B:X2}";
        }
    }
}
