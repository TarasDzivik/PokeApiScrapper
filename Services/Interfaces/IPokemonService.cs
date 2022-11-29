using Manager.PokeApi.Models.Responces;

namespace Manager.PokeApi.Services.Interfaces
{
    /// <summary>
    /// Interface for dealing with pokemon service
    /// </summary>
    public interface IPokemonService
    {
        /// <summary>
        /// Method for getting of pokemon searched
        /// </summary>
        /// <param name="pokemonName"></param>
        /// <returns>List (up to 10) of pokemon who match a search criteria</returns>
        Task<PokeSearchResponse> GetPokemonList(string pokemonName);
        /// <summary>
        /// Method for getting details on selected pokemon
        /// </summary>
        /// <param name="pokemonName"></param>
        /// <returns>Object containing pokemon detail</returns>
        Task<PokeSearchResponse> GetPokemonDetail(int pokemonId);
    }
}
