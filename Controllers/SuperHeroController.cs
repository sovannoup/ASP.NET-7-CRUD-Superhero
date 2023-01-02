using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Todo_List.Services;

namespace Todo_List.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {

        private readonly ISuperHeroService _superHeroService;

        public SuperHeroController(ISuperHeroService superHeroService) {
            this._superHeroService= superHeroService;
        }

        private static List<SuperHero> superHeros = new List<SuperHero>
            {
                new SuperHero {Id = 1, FullName = "Noup Sovan", Username = "Hiro", Place = "Phnom Penh", Contact = "012345678"}
            };
        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> GetAllSuperHeros()
        {
            var result = _superHeroService.GetAllSuperHeros();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SuperHero>> GetSingleSuperHero(int id)
        {
            var result = _superHeroService.GetSingleSuperHero(id);
            if(result == null)
            {
                return NotFound("Super Hero Not Found");
            }
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<SuperHero>>> AddHero(SuperHero hero)
        {
            var result = _superHeroService.AddHero(hero);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<SuperHero>>> UpdateHero(int id, SuperHero hero)
        {
            var result = _superHeroService.UpdateHero(id, hero);
            if (result is null)
            {
                return NotFound("Super Hero Not Found");
            }
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<SuperHero>>> DeleteSuperHero(int id)
        {
            var result = _superHeroService.DeleteSuperHero(id);
            if(result is null) {
                return NotFound("Super Hero Not Found");
            }
            return Ok(result);
        }
    }
}
