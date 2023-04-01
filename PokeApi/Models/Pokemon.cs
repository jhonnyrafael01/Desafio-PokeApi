using Newtonsoft.Json;

namespace PokeApi.Models
{
    public class Pokemon
    {
        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("types")]
        public List<PokemonType>? Types { get; set; }

        [JsonProperty("abilities")]
        public List<PokemonAbility>? Abilities { get; set; }

        [JsonProperty("weight")]
        public int Weight { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("sprites")]
        public PokemonSprites Sprites { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Types: {string.Join(", ", Types)}, Abilities: {string.Join(", ", Abilities)}, Weight: {Weight}, Height: {Height}, Sprites: {Sprites.Front_Default}";
        }
    }
}
