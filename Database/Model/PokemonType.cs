using System.Text.Json.Serialization;

namespace Manager.PokeApi.Database.Model
{
    /// <summary>
    /// Object containing data regarding pokemon type
    /// </summary>
    public class PokemonType
    {
        /// <summary>
        /// The order the pokemons types are listed in
        /// </summary>
        [JsonPropertyName("slot")]
        public int Slot { get; set; }

        /// <summary>
        /// Object containing type name and url
        /// </summary>
        [JsonPropertyName("type")]
        public NamedAPIResource Type { get; set; }
    }
}
