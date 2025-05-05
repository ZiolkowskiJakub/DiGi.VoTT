using DiGi.VoTT.Classes;

namespace DiGi.VoTT
{
    public static partial class Create
    {
        public static Tag Tag(string name)
        {
            if(string.IsNullOrWhiteSpace(name))
            {
                return null;
            }

            return new Tag(name, Query.Hex(System.Drawing.Color.Black));
        }
    }
}

