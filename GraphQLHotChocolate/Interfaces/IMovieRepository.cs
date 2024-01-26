using GraphQLHotChocolate.Models;

namespace GraphQLHotChocolate.Interfaces
{
    public interface IMovieRepository
    {
        IQueryable<Movie> GetAll();
        Task<Movie> AddMovie(Movie movie);
        Task<Movie> UpdateMovie(Movie movie);
        Task<Movie> DeleteMovie(Guid idMovie);
    }
}
