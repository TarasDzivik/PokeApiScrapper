namespace Manager.PokeApi.Models.Responces
{
    /// <summary>
    /// Object that contais data on pokemon search results
    /// </summary>
    public class PokemonBase
    {
        /// <summary>
        /// Name of the pokemon being searched
        /// </summary>
        public string PokemonName { get; set; }

        /// <summary>
        /// Id of pokemon being searched
        /// </summary>
        public int PokemonId { get; set;}
    }
}
