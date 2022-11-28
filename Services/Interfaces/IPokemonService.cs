using Manager.PokeApi.Models.Responces;

namespace Manager.PokeApi.Services.Interfaces
{
    public interface IPokemonService
    {
        Task<PokeSearchResponse> GetPokemonList(string pokemonName);
    }
}
