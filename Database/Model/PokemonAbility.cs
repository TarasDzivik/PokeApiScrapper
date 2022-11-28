using System.Text.Json.Serialization;

namespace Manager.PokeApi.Database.Model
{
    /// <summary>
    /// object containing data on pokemon abilities
    /// </summary>
    public class PokemonAbility
    {
        /// <summary>
        /// is a hidden ability
        /// </summary>
        [JsonPropertyName("is_hidden")]
        public bool IsHidden { get; set; }
        /// <summary>
        /// slot tha ability belongs in
        /// </summary>
        [JsonPropertyName("slot")]
        public int Slot { get; set; }
        /// <summary>
        /// object contains ability name and uri
        /// </summary>
        [JsonPropertyName("ability")]
        public NamedAPIResource Ability { get; set; }
    }
}
