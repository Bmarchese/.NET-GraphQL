using GraphQLHotChocolate.Models;

namespace GraphQLHotChocolate.Interfaces
{
    public interface ISuperHeroRepository
    {
        IQueryable<SuperHero> GetAll();
        Task<SuperHero> GetSuperHeroById(Guid id);
        Task<SuperHero> AddSuperHero(SuperHero hero);
        Task<SuperHero> UpdateSuperHero(SuperHero hero);
        Task<SuperHero> DeleteSuperHero(Guid idHero);
    }
}
