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
        /// <inheritdoc />
        public async Task<PokeSearchResponse> GetPokemonList(string pokemonName)
        {
            PokeSearchResponse response = new()
            {
                Errors = new List<string>(),
                PokemonList = new List<PokemonBase>()
            };
            try
            {
                // TODO: make enviremental variable
                var pokemon = await "https://pokeapi.co/api/v2/"
                    .AppendPathSegment($"pokemon/")
                    .SetQueryParam("limit=151")
                    .GetJsonAsync<Named>();

                if (pokemon == null ||
                    pokemon.Results == null)
                {
                    throw new Exception("No pokemon were returned");
                }

                List<NamedAPIResource> pokemonLIst = pokemon.Results;

                var filteredPokemon = (from poke in pokemonLIst
                                       where poke.name.Contains(pokemonName)
                                       orderby poke.name
                                       select new PokemonBase
                                       {
                                           PokemonName = poke.name,
                                           PokemonId = int.Parse(poke.url.Split("/")[6])
                                       }).Take(10).ToList();
                
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
        /// <inheritdoc />
        public Task<PokeSearchResponse> GetPokemonDetail(int pokemonId)
        {
            try
            {
                return null;
            }
            catch (Exception ex)
            {

                return null;
            }
        }
    }
}
