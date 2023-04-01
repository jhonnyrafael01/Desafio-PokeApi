using Newtonsoft.Json;

namespace PokeApi.Models
{
    public class Type
    {
        [JsonProperty("name")]
        public string? Name { get; set; }
    }
}
