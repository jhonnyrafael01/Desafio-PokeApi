using Newtonsoft.Json;

namespace PokeApi.Models
{
    public class PokemonAbility
    {
        [JsonProperty("ability")]
        public Abilitys? Ability { get; set; }

        public override string ToString()
        {
            return $"{Ability.Name}";
        }

    }
}
