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
                    .SetQueryParam("limit=1120")
                    .GetJsonAsync<Named>();
                List<NamedAPIResource> pokemonLIst = pokemon.Results;

                var filteredPokemon = (from poke in pokemonLIst
                                       where poke.name.Contains(pokemonName)
                                       orderby poke.name
                                       select poke).Take(10).ToList();
                
                if (filteredPokemon.Count < 1)
                {
                    throw new Exception($"There were no matches for {pokemonName}");
                }
                List<PokemonBase> pokemonBases = new();

                foreach (var p in filteredPokemon)
                {
                    var id = p.url.Split("/")[6];

                    PokemonBase pb = new PokemonBase
                    {
                        PokemonName = p.name,
                        PokemonId = int.Parse(id)
                    };
                    pokemonBases.Add(pb);
                }

                response.PokemonList.AddRange(pokemonBases);
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
