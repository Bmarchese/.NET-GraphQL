using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using GraphQLHotChocolate.Models;

namespace GraphQLHotChocolate.Data.ContextConfigurations
{
    public class SuperpowerContextConfiguration : IEntityTypeConfiguration<SuperPower>
    {
        private Guid[]  _ids { get; set; }

        public SuperpowerContextConfiguration(Guid[] ids) 
        {
            _ids = ids;
        }

        public void Configure(EntityTypeBuilder<SuperPower> builder)
        {
            builder
                .HasData(
                new SuperPower
                {
                    Id = Guid.NewGuid(),
                    Superpower = "Intellect.",
                    Description = "He's always a step ahead.",
                    SuperheroId = _ids[0]
                },
                new SuperPower
                {
                    Id = Guid.NewGuid(),
                    Superpower = "Fighting",
                    Description = "Sublime fighting skills.",
                    SuperheroId = _ids[0]
                },
                new SuperPower
                {
                    Id = Guid.NewGuid(),
                    Superpower = "Wealth.",
                    Description = "He got a lot of money",
                    SuperheroId = _ids[0]
                },
                new SuperPower
                {
                    Id = Guid.NewGuid(),
                    Superpower = "Deflect blaster power.",
                    Description = "Luke Skywalker is able to deflect fire from a blaster back at the opponent firing. This enables Luke to turn someone else's weapon against them.",
                    SuperheroId = _ids[1]
                },
                new SuperPower
                {
                    Id = Guid.NewGuid(),
                    Superpower = "Telekinesis",
                    Description = "Luke Skywalker has the ability to move objects with his mind. He can manipulate and control objects using telekinesis, allowing him to lift, push, or pull things without physical contact.",
                    SuperheroId = _ids[1]
                },
                new SuperPower
                {
                    Id = Guid.NewGuid(),
                    Superpower = "Force Projection",
                    Description = "Luke Skywalker possesses the rare ability to project a realistic and powerful image of himself across vast distances. This power allows him to deceive and distract his enemies, giving him an advantage in battles and strategic situations.",
                    SuperheroId = _ids[1]
                },
                new SuperPower
                {
                    Id = Guid.NewGuid(),
                    Superpower = "Spider-Sense",
                    Description = "Spider-Man's spider-sense grants him an advanced warning system, allowing him to sense danger before it occurs, including incoming attacks, imminent threats, or hidden enemies.",
                    SuperheroId = _ids[2]
                },
                new SuperPower
                {
                    Id = Guid.NewGuid(),
                    Superpower = "Increased Agility",
                    Description = "Spider-Man possesses exceptional agility and reflexes, surpassing those of a regular human. He can perform acrobatic maneuvers, dodge attacks with ease, and move swiftly in various environments, making him incredibly difficult to hit or capture.",
                    SuperheroId = _ids[2]
                },
                new SuperPower
                {
                    Id = Guid.NewGuid(),
                    Superpower = "Web-Slinging",
                    Description = "Spider-Man can generate and shoot strong, adhesive webs from devices he created called web-shooters. He uses these webs to swing through the city, create barriers, restrain enemies, or as a versatile tool in combat and rescue operations.",
                    SuperheroId = _ids[2]
                }
                );
        }
    }
}
