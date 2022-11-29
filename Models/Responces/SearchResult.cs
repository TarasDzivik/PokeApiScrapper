#nullable enable
using System.Text.Json.Serialization;

namespace Manager.PokeApi.Models.Responces
{
    /// <summary>
    /// Responce object for the return out of the API
    /// </summary>
    public class SearchResult<T>
    {
        /// <summary>
        /// Count of items being returned.
        /// </summary>
        public int? Count { get; set; }
        /// <summary>
        /// The string containing data for the next in pagination.
        /// </summary>
        public string? Next { get; set; }

        /// <summary>
        /// The string containing data for the previous in pagination.
        /// </summary>
        public string? Previos { get; set; }

        /// <summary>
        /// The list of results objects being returned.
        /// </summary>
        public List<T> Results { get; set; }
    }
}
