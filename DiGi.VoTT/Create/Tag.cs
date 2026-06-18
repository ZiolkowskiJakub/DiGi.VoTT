using DiGi.VoTT.Classes;

namespace DiGi.VoTT
{
    public static partial class Create
    {
        /// <summary>
        /// Creates a new <see cref="Tag"/> instance with the specified name and a default color.
        /// </summary>
        /// <param name="name">The name of the tag to create.</param>
        /// <returns>A <see cref="Tag"/> instance if the provided name is not null or whitespace; otherwise, <c>null</c>.</returns>
        public static Tag? Tag(string? name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return null;
            }

            return new Tag(name!, Query.Hex(System.Drawing.Color.Black));
        }
    }
}
