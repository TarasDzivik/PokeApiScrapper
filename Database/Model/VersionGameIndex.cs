using System.Text.Json.Serialization;

namespace Manager.PokeApi.Database.Model
{
    /// <summary>
    /// Object containing data on game version and index
    /// </summary>
    public class VersionGameIndex
    {
        /// <summary>
        /// What their index was in the game
        /// </summary>
        [JsonPropertyName("game_index")]
        public int GameIndex { get; set; }

        /// <summary>
        /// Object containing version name and url
        /// </summary>
        [JsonPropertyName("version")]
        public NamedAPIResource Version { get; set; }
    }
}
