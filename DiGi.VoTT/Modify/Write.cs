using DiGi.VoTT.Classes;
using System.IO;
using System.Text.Json;

namespace DiGi.VoTT
{
    public static partial class Modify
    {
        /// <summary>Writes the specified <see cref="VoTTModel"/> instance to a file in JSON format at the given path.</summary>
        /// <param name="voTTModel">The <see cref="VoTTModel"/> instance to be serialized and saved.</param>
        /// <param name="path">The destination file path where the JSON data will be written.</param>
        /// <returns><c>true</c> if the model was successfully written to the file; otherwise, <c>false</c>.</returns>
        public static bool Write(this VoTTModel voTTModel, string path)
        {
            if (voTTModel == null || string.IsNullOrWhiteSpace(path))
            {
                return false;
            }

            if (!Directory.Exists(Path.GetDirectoryName(path)))
            {
                return false;
            }

            JsonSerializerOptions jsonSerializerOptions = new()
            {
                WriteIndented = true
            };

            string json = JsonSerializer.Serialize(voTTModel, jsonSerializerOptions);

            File.WriteAllText(path, json);

            return true;
        }
    }
}
