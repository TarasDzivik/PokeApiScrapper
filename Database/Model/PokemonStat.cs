using System.Text.Json.Serialization;

namespace Manager.PokeApi.Database.Model
{
    /// <summary>
    /// Object containing pokemon stat data
    /// </summary>
    public class PokemonStat
    {
        /// <summary>
        /// Object containing name and url for stat name
        /// </summary>
        [JsonPropertyName("stat")]
        public NamedAPIResource Stat { get; set; }

        /// <summary>
        /// The effort ports the pokemon has in the stat
        /// </summary>
        [JsonPropertyName("effort")]
        public int Effort { get; set; }

        /// <summary>
        /// The base value of the stat
        /// </summary>
        [JsonPropertyName("base_stat")]
        public int BaseStat { get; set; }
    }
}
