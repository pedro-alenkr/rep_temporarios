using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Api.Entities.Jsons.JsonInput
{
    public class JsonId
    {
        [JsonPropertyName("Id")]
        public long Id { get; set; }
    }
}