using GraphQLHotChocolate.Interfaces;
using GraphQLHotChocolate.Models;
using GraphQLHotChocolate.Models.Input;
using GraphQLHotChocolate.Models.Payload;
using GraphQLHotChocolate.Repositories;

namespace GraphQLHotChocolate.Data
{
    public class Mutation
    {
        public async Task<SuperHeroPayload> CreateSuperHero([Service]ISuperHeroRepository superHeroRepository, SuperHeroInput input)
        {
            var superHero = new SuperHero
            {
                Id = Guid.NewGuid(),
                Name = input.Name,
                Description = input.Description,
                Height = input.Height
            };

            var retorno = await superHeroRepository.AddSuperHero(superHero);

            return new SuperHeroPayload(retorno);
        }

        public async Task<SuperHeroPayload> UpdateSuperHero([Service]ISuperHeroRepository superHeroRepository, SuperHeroUpdateInput input)
        {
            var superHero = new SuperHero
            {
                Id = input.Id,
                Name = input.Name,
                Description = input.Description,
                Height = input.Height
            };

            var retorno = await superHeroRepository.UpdateSuperHero(superHero);
            
            return new SuperHeroPayload(retorno);
        }

        public async Task<SuperHeroPayload> DeleteSuperHero([Service]ISuperHeroRepository superHeroRepository, SuperHeroDeleteInput input)
        {
            var retorno = await superHeroRepository.DeleteSuperHero(input.Id);

            return new SuperHeroPayload(retorno);
        }

        public async Task<MoviePayload> CreateMovie([Service]IMovieRepository movieRepository, MovieInput input)
        {
            var movie = new Movie
            {
                Id = Guid.NewGuid(),
                Title = input.Title,
                Description = input.Description,
                Instructor = input.Instructor,
                ReleaseDate = input.ReleaseDate,
                SuperheroId = input.SuperheroId
            };

            await movieRepository.AddMovie(movie);
            return new MoviePayload
            (
                movie.Id,
                movie.Title,
                movie.Description,
                movie.Instructor,
                movie.ReleaseDate,
                movie.SuperheroId
            );
        }

        public async Task<MoviePayload> UpdateMovie([Service]IMovieRepository movieRepository, MovieUpdateInput input)
        {
            var movie = new Movie
            {
                Id = input.Id,
                Title = input.Title,
                Description = input.Description,
                Instructor = input.Instructor,
                ReleaseDate = input.ReleaseDate,
                SuperheroId = input.SuperheroId
            };

            var retorno = await movieRepository.UpdateMovie(movie);
            return new MoviePayload
            (
                retorno.Id,
                retorno.Title,
                retorno.Description,
                retorno.Instructor,
                retorno.ReleaseDate,
                retorno.SuperheroId
            );
        }

        public async Task<MoviePayload> DeleteMovie([Service]IMovieRepository movieRepository, MovieDeleteInput input)
        {
            var retorno = await movieRepository.DeleteMovie(input.Id);
            return new MoviePayload
            (
                retorno.Id,
                retorno.Title,
                retorno.Description,
                retorno.Instructor,
                retorno.ReleaseDate,
                retorno.SuperheroId
            );
        }

        public async Task<SuperPowerPayload> CreateSuperPower([Service] ISuperPowerRepository superPowerRepository, SuperPowerInput input)
        {
            var power = new SuperPower
            {
                Id = Guid.NewGuid(),
                Superpower = input.Power,
                Description = input.Description,
                SuperheroId = input.SuperheroId
            };

            await superPowerRepository.AddSuperPower(power);
            return new SuperPowerPayload
            (
                power.Id,
                power.Superpower,
                power.Description,
                power.SuperheroId
            );
        }

        public async Task<SuperPowerPayload> UpdateSuperPower([Service]ISuperPowerRepository superPowerRepository, SuperPowerUpdateInput input)
        {
            var power = new SuperPower
            {
                Id = Guid.NewGuid(),
                Superpower = input.Power,
                Description = input.Description,
                SuperheroId = input.SuperheroId
            };

            await superPowerRepository.UpdateSuperPower(power);
            return new SuperPowerPayload
            (
                power.Id,
                power.Superpower,
                power.Description,
                power.SuperheroId
            );
        }

        public async Task<SuperPowerPayload> DeleteSuperPower([Service]ISuperPowerRepository superPowerRepository, SuperPowerDeleteInput input)
        {
            var retorno = await superPowerRepository.DeleteSuperPower(input.Id);
            return new SuperPowerPayload(retorno.SuperheroId, retorno.Superpower, retorno.Description, retorno.SuperheroId) ;
        }
    }
}
