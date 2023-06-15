using System.Text.Json.Serialization;

namespace Api.Entities.Jsons.JsonInput
{
    public class JsonMethod
    {
        
        [JsonPropertyName("Method")]
        public string Method { get; set; } = string.Empty;
    }
}