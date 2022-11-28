using Manager.PokeApi.Database.Model;
using Flurl;
using Flurl.Http;
using Manager.PokeApi.Services.Interfaces;
using Manager.PokeApi.Models.Responces;

namespace Manager.PokeApi.Services
{
    /// <summary>
    /// Service for handling Pokemon related requests
    /// </summary>
    public class PocemonService : IPokemonService
    {
        public async Task<PokeSearchResponse> GetPokemonList(string pokemonName)
        {
            PokeSearchResponse response = new()
            {
                Errors = new List<string>(),
                PokemonList = new List<NamedAPIResource>()
            };
            try
            {
                // TODO: make enviremental variable
                var pokemon = await "https://pokeapi.co/api/v2/"
                    .AppendPathSegment($"pokemon/")
                    .SetQueryParam("limit=1120")
                    .GetJsonAsync<Named>();
                List<NamedAPIResource> pokemonLIst = pokemon.Results;

                var filteredPokemon = (from poke in pokemonLIst
                                       where poke.name.Contains(pokemonName)
                                       select poke).Take(10).ToList();
                
                if (filteredPokemon.Count < 1)
                {
                    throw new Exception($"There were no matches for {pokemonName}");
                }

                response.PokemonList.AddRange(filteredPokemon);
                return response;
            }
            catch (Exception ex)
            {
                response.Errors.Add(ex.Message);
                return response;
            }
        }
    }
}
