using System.Text.Json.Serialization;

namespace Manager.PokeApi.Database.Model
{
    /// <summary>
    /// object containing data on the held items on a pokemon
    /// </summary>
    public class PokemonHeldItem
    {
        /// <summary>
        /// The item referenced pokenmon holds
        /// </summary>
        [JsonPropertyName("item")]
        public NamedAPIResource Item { get; set; }

        /// <summary>
        /// The details of the different versions in which the item is held
        /// </summary>
        [JsonPropertyName("version_deails")]
        public PokemonHeldItem VersionDetails { get; set; } 

    }
}
