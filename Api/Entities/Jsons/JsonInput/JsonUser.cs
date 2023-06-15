using System.Text.Json.Serialization;

namespace Api.Entities.Jsons.JsonInput
{
    public class JsonUser
    {
        [JsonPropertyName("Name")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("Password")]
        public string Password { get; set; } = string.Empty;

        [JsonPropertyName("Email")]
        public string Email { get; set; } = string.Empty;

        [JsonPropertyName("PhoneNumber")]
        public string PhoneNumber { get; set; } = string.Empty;

        [JsonPropertyName("UserType")]
        public int UserType { get; set; }
    }
}