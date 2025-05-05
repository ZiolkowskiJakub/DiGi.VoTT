using System.Text.Json.Serialization;

namespace DiGi.VoTT.Classes
{
    public class Tag
    {
        public string name { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? color { get; set; }

        public Tag(string name, string? color = null)
        {
            this.name = name;
            this.color = color;
        }
    }
}
