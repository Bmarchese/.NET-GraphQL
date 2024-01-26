using GraphQLHotChocolate.Models;
using GraphQLHotChocolate.Interfaces;
using System.Runtime.CompilerServices;

namespace GraphQLHotChocolate.Data
{
    public class Query
    {
 
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<SuperHero> GetSuperHeroes([Service] ISuperHeroRepository superHeroRepository) => superHeroRepository.GetAll();
        
        [UseProjection]
        public async Task<SuperHero> GetSuperHero([Service] ISuperHeroRepository superHeroRepository, Guid id) => await superHeroRepository.GetSuperHeroById(id);

        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Movie> GetMovies([Service] IMovieRepository movieRepository) => movieRepository.GetAll();

        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<SuperPower> GetSuperPowers([Service] ISuperPowerRepository superPowerRepository) => superPowerRepository.GetAll();
    }
}
