using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using GraphQLHotChocolate.Models;

namespace GraphQLHotChocolate.Data.ContextConfigurations
{
    public class SuperheroContextConfiguration : IEntityTypeConfiguration<SuperHero>
    {
        private Guid[] _ids;

        public SuperheroContextConfiguration(Guid[] ids)
        {
            _ids = ids;
        }

        public void Configure(EntityTypeBuilder<SuperHero> builder)
        {
            builder
                .HasData(
                new SuperHero
                {
                    Id = _ids[0],
                    Name = "Batman",
                    Description = "Batman was originally introduced as a ruthless vigilante who frequently killed or maimed criminals, but evolved into a character with a stringent moral code and strong sense of justice. Unlike most superheroes, Batman does not possess any superpowers, instead relying on his intellect, fighting skills, and wealth.",
                    Height = 1.93
                },
                new SuperHero
                {
                    Id = _ids[1],
                    Name = "Luke Skywalker",
                    Description = "Luke Skywalker was a Tatooine farmboy who rose from humble beginnings to become one of the greatest Jedi the galaxy has ever known. Along with his friends Princess Leia and Han Solo, Luke battled the evil Empire, discovered the truth of his parentage, and ended the tyranny of the Sith.",
                    Height = 1.70
                },
                new SuperHero
                {
                    Id = _ids[2],
                    Name = "Spider-Man",
                    Description = "Spider-Man, also known as Peter Parker, is a teenage superhero with the proportionate strength, speed, and agility of a spider. He can cling to walls and has a spider-sense that alerts him to danger. Spider-Man uses his powers to protect New York City from various supervillains.",
                    Height = 1.78
                });
        }
    }
}
