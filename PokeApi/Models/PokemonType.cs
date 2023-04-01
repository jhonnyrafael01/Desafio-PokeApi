using Newtonsoft.Json;

namespace PokeApi.Models
{
    public class PokemonType
    {
        [JsonProperty("type")]
        public Type? Type { get; set; }

        public override string ToString()
        {
            return $"{Type.Name}";
        }
    }
}
