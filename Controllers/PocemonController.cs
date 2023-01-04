using Manager.PokeApi.Database.Model;
using Manager.PokeApi.Models.Responces;
using Manager.PokeApi.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Manager.PokeApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class PocemonController : ControllerBase
    {
        #region Fields
        private readonly IPokemonService _poke;

        #endregion
        #region CTOR
        public PocemonController(IPokemonService poke) 
        { 
            _poke = poke;
        }
        #endregion
        #region Calls

        /// <summary>
        /// Api Call for a list pokemon names that match search box entry
        /// </summary>
        /// <returns>object containing a list of 10 pokemon that math search entry</returns>
        [HttpGet("PokemonNameList/{pokemonName}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<SearchResult<PokemonBase>>> GetPokemonList(string pokemonName)
        {
            try
            {
                var pokemonReturn = await _poke.GetPokemonList(pokemonName);
                var listReturn = pokemonReturn.PokemonList;

                if (pokemonReturn.Errors.Count > 0)
                {
                    throw new Exception(string.Join(", ", pokemonReturn.Errors));
                }
                
                return Ok(new SearchResult<PokemonBase>
                {
                    Count = listReturn.Count(),
                    Next = null,
                    Previos = null,
                    Results = listReturn
                });
            }
            catch (Exception ex)
            {
                // log ex.message  to our error log (if it exist)
                return BadRequest();
            }
        }

        /// <summary>
        /// Api Call for a data on the selected pokemon
        /// </summary>
        /// <returns>An object containing pokemon</returns>
        [HttpGet("PokemonDetails/{pokemonUrl}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<SearchResult<PokeDetails>>> GetPokemon(int pokemonId)
        {
            try
            {
                PokeDetails respone = new();
                var pokemonDetail = await _poke.GetPokemonDetail(pokemonId);

                return Ok(respone);
            }
            catch (Exception ex)
            {
                return BadRequest();
                throw;
            }
        }
        #endregion

    }
}
