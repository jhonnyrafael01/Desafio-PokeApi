using Newtonsoft.Json;

namespace PokeApi.Models
{
    public class PokemonSprites
    {
        [JsonProperty("front_Default")]
        public string? Front_Default { get; set; }
    }
}
