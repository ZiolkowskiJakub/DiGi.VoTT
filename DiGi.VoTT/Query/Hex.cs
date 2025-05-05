
namespace DiGi.VoTT
{
    public static partial class Query
    {
        public static string Hex(this System.Drawing.Color color)
        {
            return $"#{color.R:X2}{color.G:X2}{color.B:X2}";
        }
    }
}

