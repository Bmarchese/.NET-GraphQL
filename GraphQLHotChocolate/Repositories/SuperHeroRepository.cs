using GraphQLHotChocolate.Data;
using GraphQLHotChocolate.Interfaces;
using GraphQLHotChocolate.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQLHotChocolate.Repositories
{
    public class SuperHeroRepository : ISuperHeroRepository
    {
        private readonly ApplicationDbContext _context;

        public SuperHeroRepository([Service]ApplicationDbContext context)
        {
            _context = context;
        }

        public IQueryable<SuperHero> GetAll()
        {
            return _context.Superheroes.AsQueryable();
        }

        public async Task<SuperHero> AddSuperHero(SuperHero hero)
        {
            await _context.Superheroes.AddAsync(hero);
            await _context.SaveChangesAsync();
            return hero;
        }

        public async Task<SuperHero> UpdateSuperHero(SuperHero hero)
        {
             _context.Superheroes.Update(hero);
            await _context.SaveChangesAsync();
            return hero;
        }

        public async Task<SuperHero> DeleteSuperHero(Guid idHero)
        {
            var hero = await _context.Superheroes.FirstAsync(x => x.Id == idHero);
            
            _context.Superheroes.Remove(hero);
            await _context.SaveChangesAsync();

            return hero;
        }

        public async Task<SuperHero> GetSuperHeroById(Guid id)
        {
            var hero = await _context.Superheroes.FirstAsync(x => x.Id == id);
            return hero;
        }
    }
}
