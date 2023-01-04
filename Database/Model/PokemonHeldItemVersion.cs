using System.Text.Json.Serialization;

namespace Manager.PokeApi.Database.Model
{
    /// <summary>
    /// Object containing held item version details
    /// </summary>
    public class PokemonHeldItemVersion
    {
        /// <summary>
        /// Object containing version details
        /// </summary>
        [JsonPropertyName("version")]
        public NamedAPIResource Version { get; set; }

        /// <summary>
        /// How often the item is held
        /// </summary>
        [JsonPropertyName("rarity")]
        public int Rarity { get; set; }
    }
}
