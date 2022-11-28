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
        public async Task<ActionResult> GetPokemonList(string pokemonName)
        {
            try
            {
                await _poke.GetPokemonList(pokemonName);

                return Ok();
            }
            catch (Exception ex)
            {
                // we can add log this
                return BadRequest();
            }
        }
        #endregion

    }
}
