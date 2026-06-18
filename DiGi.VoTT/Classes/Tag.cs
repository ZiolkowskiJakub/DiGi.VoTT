using System.Text.Json.Serialization;

namespace DiGi.VoTT.Classes
{
    /// <summary>
    /// Represents a tag used for categorization or labeling, containing a name and an optional associated color.
    /// </summary>
    public class Tag
    {
        /// <summary>
        /// Gets or sets the name of the tag.
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Gets or sets the optional color associated with the tag.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? color { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Tag"/> class.
        /// </summary>
        /// <param name="name">The name of the tag.</param>
        /// <param name="color">The optional color associated with the tag.</param>
        public Tag(string name, string? color = null)
        {
            this.name = name;
            this.color = color;
        }
    }
}
