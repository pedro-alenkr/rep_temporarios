using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Api.Entities.Jsons.JsonInput
{
    public class JsonEmailAndPassword
    {
        [JsonPropertyName("Email")]
        public string Email { get; set; } = string.Empty;

        [JsonPropertyName("Password")]
        public string Password { get; set; } = string.Empty;
    }
}