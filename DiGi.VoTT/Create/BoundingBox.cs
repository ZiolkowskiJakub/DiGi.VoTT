using DiGi.VoTT.Classes;

namespace DiGi.VoTT
{
    public static partial class Create
    {
        public static BoundingBox BoundingBox(double x_1, double y_1, double x_2, double y_2)
        {
            if(double.IsNaN(x_1) || double.IsNaN(y_1) || double.IsNaN(x_2) || double.IsNaN(y_2))
            {
                return null;
            }

            return new BoundingBox()
            {
                left = System.Convert.ToSingle( System.Math.Min(x_1, x_2)),
                top = System.Convert.ToSingle(System.Math.Min(y_1, y_2)),
                height = System.Convert.ToSingle(System.Math.Max(y_1, y_2) - System.Math.Min(y_1, y_2)),
                width = System.Convert.ToSingle(System.Math.Max(x_1, x_2) - System.Math.Min(x_1, x_2))
            };
        }
    }
}

