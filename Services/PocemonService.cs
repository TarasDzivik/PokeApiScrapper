using Manager.PokeApi.Database.Model;
using Flurl;
using Flurl.Http;
using Manager.PokeApi.Services.Interfaces;

namespace Manager.PokeApi.Services
{
    /// <summary>
    /// Service for handling Pokemon related requests
    /// </summary>
    public class PocemonService : IPokemonService
    {
        public async Task GetPokemonList(string pokemonName)
        {
            try
            {
                // TODO: make enviremental variable
                var pokemon = await "https://pokeapi.com/api/v2/"
                    .AppendPathSegment($"pokemon/")
                    .SetQueryParam("limit=1120")
                    .GetJsonAsync<Named>();
                List<NamedAPIResorce> pokemonLIst = pokemon.Results;

                var stop = 1;
            }
            catch (Exception ex)
            {

            }
        }
    }
}
