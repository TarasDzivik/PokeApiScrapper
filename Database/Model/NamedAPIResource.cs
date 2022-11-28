using System.Text.Json.Serialization;

namespace Manager.PokeApi.Database.Model
{
    /// <summary>
    /// object containing name and url for the resorces
    /// </summary>
    public class NamedAPIResource
    {
        /// <summary>
        /// name of the object
        /// </summary>
        [JsonPropertyName("name")]
        public string name { get; set; }

        /// <summary>
        /// url to the object
        /// </summary>
        [JsonPropertyName("url")]
        public string url { get; set; }
    }
}
