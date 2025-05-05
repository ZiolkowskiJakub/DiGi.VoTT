using DiGi.VoTT.Classes;
using System.IO;
using System.Text.Json;

namespace DiGi.VoTT
{
    public static partial class Modify
    {
        public static bool Write(this VoTTModel voTTModel, string path)
        {
            if(voTTModel == null || string.IsNullOrWhiteSpace(path))
            {
                return false;
            }

            if(!Directory.Exists(Path.GetDirectoryName(path)))
            {
                return false;
            }

            JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions 
            { 
                WriteIndented = true 
            };
            
            string json = JsonSerializer.Serialize(voTTModel, jsonSerializerOptions);
            
            File.WriteAllText(path, json);

            return true;
        }
    }
}

