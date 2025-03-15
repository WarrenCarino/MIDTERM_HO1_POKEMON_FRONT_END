using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Pokemonbackend_Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Pokedex : ControllerBase
    {
        // Corrected placement of HttpGet and Route attributes
        [HttpGet]
        [Route("get-by-type")]
        public IActionResult GetByType(string? name)
        {
            // Your logic to handle the "name" query parameter would go here
            return Ok();
        }
        [HttpPost]
        public IActionResult Post([FromBody] Pokemontoh dto)
        {
            try
            {
                PokemonRepository.AddPokemon(dto);
                return Created();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut]
        public IActionResult Put([FromBody] Pokemontoh dto)
        {
            return Put(dto);
        }
        [HttpDelete]
        public IActionResult Delete([FromBody] Pokemontoh dto)
        {
            return Ok();
        }
    }
}
