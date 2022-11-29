using Manager.PokeApi.Database.Model;

namespace Manager.PokeApi.Models.Responces
{
    /// <summary>
    /// Object that contains response of pokemon search
    /// </summary>
    public class PokeSearchResponse
    {
        /// <summary>
        /// List of errors messages
        /// </summary>
        public List<string> Errors { get; set; }
        /// <summary>
        /// List of pokemon found in the search
        /// </summary>
        public List<PokemonBase> PokemonList { get; set; }
    }
}
