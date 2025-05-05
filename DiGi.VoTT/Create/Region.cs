using DiGi.VoTT.Classes;

namespace DiGi.VoTT
{
    public static partial class Create
    {
        public static Region Region(this BoundingBox boundingBox, string tagName)
        {
            if(boundingBox == null || string.IsNullOrWhiteSpace(tagName))
            {
                return null;
            }

            Region result = new Region()
            {
                tagName = tagName,
                boundingBox = boundingBox,
                points = Query.Points(boundingBox),
            };

            return result;
        }
    }
}

