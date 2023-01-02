using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Todo_List.Models;

namespace Todo_List.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {

        private static List<SuperHero> superHeros = new List<SuperHero>
            {
                new SuperHero {Id = 1, FullName = "Noup Sovan", Username = "Hiro", Place = "Phnom Penh", Contact = "012345678"}
            };
        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> GetAllSuperHeros()
        {
            var superHeros = new List<SuperHero>
            {
                new SuperHero {Id = 1, FullName = "Noup Sovan", Username = "Hiro", Place = "Phnom Penh", Contact = "012345678"}
            };
            return Ok(superHeros);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SuperHero>> GetSingleSuperHero(int id)
        {
            var singleHero = superHeros.Find(x => x.Id == id);
            if(singleHero is null)
            {
                return NotFound("Hero Not Found!");
            }
            return Ok(singleHero);
        }

        [HttpPost]
        public async Task<ActionResult<List<SuperHero>>> AddHero(SuperHero hero)
        {
            superHeros.Add(hero);
            return Ok(superHeros);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<SuperHero>>> UpdateHero(int id, SuperHero hero)
        {
            var singleHero = superHeros.Find(x => x.Id == id);
            if (singleHero is null)
            {
                return NotFound("Hero Not Found!");
            }
            singleHero.FullName = hero.FullName;
            singleHero.Username = hero.Username;
            singleHero.Place = hero.Place;
            singleHero.Contact = hero.Contact;
            return Ok(superHeros);
        }
    }
}
