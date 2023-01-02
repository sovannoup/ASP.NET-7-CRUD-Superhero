using Todo_List.Models;

namespace Todo_List.Services
{
    public interface ISuperHeroService
    {
        List<SuperHero> GetAllSuperHeros();
        SuperHero GetSingleSuperHero(int id);
        List<SuperHero> AddHero(SuperHero hero);
        List<SuperHero>? UpdateHero(int id, SuperHero hero);
        List<SuperHero>? DeleteSuperHero(int id);

    }
}
