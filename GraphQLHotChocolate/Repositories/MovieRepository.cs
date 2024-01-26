using GraphQLHotChocolate.Data;
using GraphQLHotChocolate.Interfaces;
using GraphQLHotChocolate.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQLHotChocolate.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly ApplicationDbContext _context;

        public MovieRepository([Service]ApplicationDbContext context)
        {
            _context = context;
        }

        public IQueryable<Movie> GetAll()
        {
            return _context.Movies;
        }

        public async Task<Movie> AddMovie(Movie movie)
        {
            await _context.Movies.AddAsync(movie);
            await _context.SaveChangesAsync();
            return movie;
        }

        public async Task<Movie> UpdateMovie(Movie movie)
        {
            _context.Movies.Update(movie);
            await _context.SaveChangesAsync();
            return movie;
        }

        public async Task<Movie> DeleteMovie(Guid idMovie)
        {
            var movie = await _context.Movies.FirstAsync(x => x.Id == idMovie);
            _context.Movies.Remove(movie);
            await _context.SaveChangesAsync();
            return movie;
        }
    }
}
