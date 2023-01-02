namespace Todo_List.Services
{
    public class SuperHeroService : ISuperHeroService
    {
        private static List<SuperHero> superHeros = new List<SuperHero>
            {
                new SuperHero {Id = 1, FullName = "First Hero1", Username = "Hiro1", Place = "Phnom Penh", Contact = "012345678"},
                new SuperHero {Id = 2, FullName = "Second Hero2", Username = "Hiro2", Place = "Cambodia", Contact = "8552342342"}
            };
        public List<SuperHero> AddHero(SuperHero hero)
        {
            superHeros.Add(hero);
            return superHeros;
        }

        public List<SuperHero>? DeleteSuperHero(int id)
        {
            var singleHero = superHeros.Find(x => x.Id == id);
            if (singleHero is null)
            {
                return null;
            }
            superHeros.Remove(singleHero);
            return superHeros;
        }

        public List<SuperHero> GetAllSuperHeros()
        {
            return superHeros;
        }

        public SuperHero GetSingleSuperHero(int id)
        {
            var singleHero = superHeros.Find(x => x.Id == id);
            if (singleHero is null)
            {
                return null;
            }
            return singleHero;
        }

        public List<SuperHero>? UpdateHero(int id, SuperHero hero)
        {
            var singleHero = superHeros.Find(x => x.Id == id);
            if (singleHero is null)
            {
                return null;
            }
            singleHero.FullName = hero.FullName;
            singleHero.Username = hero.Username;
            singleHero.Place = hero.Place;
            singleHero.Contact = hero.Contact;
            return superHeros;
        }
    }
}
