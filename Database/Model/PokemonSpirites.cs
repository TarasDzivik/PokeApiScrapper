using System.Text.Json.Serialization;

namespace Manager.PokeApi.Database.Model
{
    /// <summary>
    /// Object containing data on the pokemon sprites
    /// </summary>
    public class PokemonSpirites
    {
        /// <summary>
        /// Default depiction of the pokemon from the front
        /// </summary>
        [JsonPropertyName("front_default")]
        public string Front_Default { get; set; }

        /// <summary>
        /// Shiny depiction of the pokemon from the front
        /// </summary>
        [JsonPropertyName("front_shiny")]
        public string Front_Shiny { get; set; }

        /// <summary>
        /// Female depiction of the pokemon from the front
        /// </summary>
        [JsonPropertyName("front_female")]
        public string Front_Female { get; set; }

        /// <summary>
        /// Female shiny depiction of the pokemon from the front
        /// </summary>
        [JsonPropertyName("front_shiny_female")]
        public string Front_Shiny_Female { get; set; }

        /// <summary>
        /// Default depiction of the pokemon from the back
        /// </summary>
        [JsonPropertyName("back_default")]
        public string Back_Default { get; set; }

        /// <summary>
        /// Shiny depiction of the pokemon from the back
        /// </summary>
        [JsonPropertyName("back_shiny")]
        public string Back_Shiny { get; set; }

        /// <summary>
        /// Female depiction of the pokemon from the back
        /// </summary>
        [JsonPropertyName("back_female")]
        public string Back_Female { get; set; }

        /// <summary>
        /// Female shiny depiction of the pokemon from the back
        /// </summary>
        [JsonPropertyName("back_shiny_female")]
        public string Back_Shiny_Female { get; set; }
    }
}
