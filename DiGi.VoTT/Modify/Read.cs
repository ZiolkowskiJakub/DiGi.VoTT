using DiGi.VoTT.Classes;
using System.IO;
using System.Text.Json;

namespace DiGi.VoTT
{
    public static partial class Modify
    {
        public static VoTTModel Read(string path)
        {
            if(string.IsNullOrWhiteSpace(path) || !File.Exists(path))
            {
                return null;
            }

            string json = File.ReadAllText(path);
            if(string.IsNullOrWhiteSpace(json))
            {
                return null;
            }


            JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions 
            { 
                WriteIndented = true 
            };


            VoTTModel result = JsonSerializer.Deserialize<VoTTModel>(json, jsonSerializerOptions);
            
            return result;
        }
    }
}

