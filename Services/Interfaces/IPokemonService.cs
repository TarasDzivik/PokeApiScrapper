namespace Manager.PokeApi.Services.Interfaces
{
    public interface IPokemonService
    {
        Task GetPokemonList(string pokemonName);
    }
}
