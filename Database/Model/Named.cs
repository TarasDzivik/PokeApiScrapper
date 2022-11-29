#nullable disable
using System.Text.Json.Serialization;

namespace Manager.PokeApi.Database.Model
{
    /// <summary>
    /// object that contains named search results
    /// </summary>
    public class Named
    {
        /// <summary>
        /// the total numbers of resources available from this API
        /// </summary>
        [JsonPropertyName("count")]
        public int Count { get; set; }

        /// <summary>
        /// the URL for the next page in the list
        /// </summary>
        [JsonPropertyName("next")]
        public string? Next { get; set; }

        /// <summary>
        /// the URL for the previous page in the list
        /// </summary>
        [JsonPropertyName("previous")]
        public string? Previous { get; set; }

        /// <summary>
        /// a List of named API resorces
        /// </summary>
        [JsonPropertyName("results")]
        public List<NamedAPIResource> Results { get; set; } = null!;
    }
}
