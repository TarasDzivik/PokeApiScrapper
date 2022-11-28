using System.Text.Json.Serialization;

namespace Manager.PokeApi.Database.Model
{
    /// <summary>
    /// object containing data on the held items on a pokemon
    /// </summary>
    public class PokemonHeldItem
    {
        /// <summary>
        /// the item referenced pokenmon holds
        /// </summary>
        [JsonPropertyName("item")]
        public NamedAPIResorce Item { get; set; }

        /// <summary>
        /// the details of the different versions in which the item is held
        /// </summary>
        [JsonPropertyName("version_deails")]
        public PokemonHeldItem VersionDetails { get; set; } 

    }
}
