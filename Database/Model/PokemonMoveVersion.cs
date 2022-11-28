using System.Text.Json.Serialization;

namespace Manager.PokeApi.Database.Model
{
    /// <summary>
    /// Object containing move data for specific versions
    /// </summary>
    public class PokemonMoveVersion
    {
        /// <summary>
        /// Method by which the move is learned
        /// </summary>
        [JsonPropertyName("move_learn_method")]
        public NamedAPIResource MoveLearnVersion { get; set; }

        /// <summary>
        /// The version group in which the move is learned
        /// </summary>
        [JsonPropertyName("version_group")]
        public NamedAPIResource VersionGroup { get; set; }

        /// <summary>
        /// The minimum level to learn the move
        /// </summary>
        [JsonPropertyName("level_learned_at")]
        public int LevelLearnedAt { get; set; }
    }
}
