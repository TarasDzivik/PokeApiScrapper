using System.Text.Json.Serialization;

namespace Manager.PokeApi.Database.Model
{
    /// <summary>
    /// object contains data on pokemon moves
    /// </summary>
    public class PokemonMove
    {
        /// <summary>
        /// object contains the name and url of the move that the pokemon can learn
        /// </summary>
        [JsonPropertyName("move")]
        public NamedAPIResorce Move { get; set; }

        /// <summary>
        /// the details of the version in whith the pokemon can learn the move
        /// </summary>
        [JsonPropertyName("verson_group_details")]
        public List<PokemonMoveVersion> VersionGroupDetails { get; set; }
    }
}
