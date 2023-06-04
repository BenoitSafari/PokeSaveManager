using System.Text.Json;

namespace PokeSaveManager.Core.Services
{
    public class JsonService
    {
        private static readonly JsonSerializerOptions JsonConfig = new()
        {
            PropertyNameCaseInsensitive = true,
            ReadCommentHandling = JsonCommentHandling.Skip,
            AllowTrailingCommas = true,
        };

        /// <summary>
        /// Deserializes a JSON file into an object. If the file is invalid the function returns the default object constructor.
        /// </summary>
        /// <param name="path">Path to the JSON file</param>
        /// <typeparam name="T">Type of the object to deserialize into, must have a default constructor</typeparam>
        /// <returns>Deserialized object or default object</returns>
        public static T Deserialize<T>(string path) where T : new()
        {
            if (!File.Exists(path)) return new T();
            using var openStream = File.OpenRead(path);

            try
            {
                return JsonSerializer.Deserialize<T>(openStream, JsonConfig) ?? new T();
            }
            catch (JsonException)
            {
                return new T();
            }
        }
    }
}
