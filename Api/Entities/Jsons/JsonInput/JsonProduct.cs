using System.Text.Json.Serialization;

namespace Api.Entities.Jsons.JsonInput
{
    public class JsonProduct
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("nome")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("valor")]
        public decimal Value { get; set; }

        [JsonPropertyName("quantidade")]
        public int Amount { get; set; }

        [JsonPropertyName("descricao")]
        public string Description { get; set; } = string.Empty;

    }
}