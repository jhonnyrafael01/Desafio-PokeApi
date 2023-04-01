using Newtonsoft.Json;

namespace PokeApi.Models
{
    public class Abilitys
    {
        [JsonProperty("name")]
        public string? Name { get; set; }
    }
}
