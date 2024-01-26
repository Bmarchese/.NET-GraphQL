using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using GraphQLHotChocolate.Models;

namespace GraphQLHotChocolate.Data.ContextConfigurations
{
    public class MovieContextConfiguration : IEntityTypeConfiguration<Movie>
    {
        private Guid[] _ids;

        public MovieContextConfiguration(Guid[] ids)
        {
            _ids = ids;
        }

        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder
                .HasData(
                new Movie
                {
                    Id = Guid.NewGuid(),
                    Title = "Batman Begins",
                    Description = "Batman Begins is a 2005 superhero film directed by Christopher Nolan and written by Nolan and David S. Goyer. Based on the DC Comics character Batman, it stars Christian Bale as Bruce Wayne / Batman, with Michael Caine, Liam Neeson, Katie Holmes, Gary Oldman,",
                    Instructor = "Christopher Nolan",
                    ReleaseDate = new DateTime(2005, 06, 25),
                    SuperheroId = _ids[0]
                },
                new Movie
                {
                    Id = Guid.NewGuid(),
                    Title = "The Dark Knight",
                    Description = "The Dark Knight is a 2008 superhero film directed, produced, and co-written by Christopher Nolan. Based on the DC Comics character Batman, the film is the second installment of Nolan's The Dark Knight Trilogy and a sequel to 2005's Batman Begins, starring Christian Bale and supported by Michael Caine, Heath Ledger, Gary Oldman, Aaron Eckhart, Maggie Gyllenhaal, and Morgan Freeman.",
                    Instructor = "Christopher Nolan",
                    ReleaseDate = new DateTime(2008, 07, 18),
                    SuperheroId = _ids[0]
                },
                new Movie
                {
                    Id = Guid.NewGuid(),
                    Title = "The Dark Knight Rises",
                    Description = "The Dark Knight Rises is a 2012 superhero film directed by Christopher Nolan, who co-wrote the screenplay with his brother Jonathan Nolan, and the story with David S. Goyer.",
                    Instructor = "Christopher Nolan",
                    ReleaseDate = new DateTime(2012, 7, 20),
                    SuperheroId = _ids[0]
                },
                new Movie
                {
                    Id = Guid.NewGuid(),
                    Title = "The Batman",
                    Description = "The Batman is a reboot of the Batman film franchise. The film was directed by Matt Reeves, who wrote the screenplay with Peter Craig.",
                    Instructor = "Matt Reeves",
                    ReleaseDate = new DateTime(2022, 3, 3),
                    SuperheroId = _ids[0]
                },
                new Movie
                {
                    Id = Guid.NewGuid(),
                    Title = "Star Wars: Episode IV – A New Hope",
                    Description = "Star Wars (retroactively titled Star Wars: Episode IV – A New Hope) is a 1977 American epic space opera film written and directed by George Lucas, produced by Lucasfilm and distributed by 20th Century Fox.",
                    Instructor = "George Lucas",
                    ReleaseDate = new DateTime(1977, 05, 25),
                    SuperheroId = _ids[1]
                },
                new Movie
                {
                    Id = Guid.NewGuid(),
                    Title = "Star Wars: Episode V – The Empire Strikes Back",
                    Description = "The Empire Strikes Back (also known as Star Wars: Episode V – The Empire Strikes Back) is a 1980 American epic space opera film directed by Irvin Kershner and written by Leigh Brackett and Lawrence Kasdan, based on a story by George Lucas.",
                    Instructor = "Irvin Kershner",
                    ReleaseDate = new DateTime(1980, 05, 21),
                    SuperheroId = _ids[1]
                },
                new Movie
                {
                    Id = Guid.NewGuid(),
                    Title = "Star Wars: Episode VI – Return of the Jedi",
                    Description = "Return of the Jedi (also known as Star Wars: Episode VI – Return of the Jedi) is a 1983 American epic space opera film directed by Richard Marquand. The screenplay is by Lawrence Kasdan and George Lucas from a story by Lucas, who was also the executive producer.",
                    Instructor = "Richard Marquand",
                    ReleaseDate = new DateTime(1983, 05, 25),
                    SuperheroId = _ids[1]
                },
                new Movie
                {
                    Id = Guid.NewGuid(),
                    Title = "Spider-Man: Homecoming",
                    Description = "Spider-Man: Homecoming is a 2017 American superhero film based on the Marvel Comics character Spider-Man. It is the second reboot of the Spider-Man film franchise and the sixteenth film in the Marvel Cinematic Universe (MCU). The movie follows the story of Peter Parker as he navigates high school life and his newfound abilities as Spider-Man, while facing the villainous Vulture.",
                    Instructor = "Jon Watts",
                    ReleaseDate = new DateTime(2017, 07, 07),
                    SuperheroId = _ids[2]
                },
                new Movie
                {
                    Id = Guid.NewGuid(),
                    Title = "Spider-Man: Far From Home",
                    Description = "Spider-Man: Far From Home is a 2019 American superhero film based on the Marvel Comics character Spider-Man. It is the sequel to Spider-Man: Homecoming and the 23rd film in the Marvel Cinematic Universe (MCU). In the movie, Peter Parker embarks on a school trip to Europe but is recruited by Nick Fury to help fight against the Elementals, alongside the mysterious superhero Mysterio.",
                    Instructor = "Jon Watts",
                    ReleaseDate = new DateTime(2019, 07, 02),
                    SuperheroId = _ids[2]
                },
                new Movie
                {
                    Id = Guid.NewGuid(),
                    Title = "Spider-Man: No Way Home",
                    Description = "Spider-Man: No Way Home is an upcoming American superhero film based on the Marvel Comics character Spider-Man. It is the third film in the Spider-Man: Homecoming trilogy and the 27th film in the Marvel Cinematic Universe (MCU). The movie will continue the story of Peter Parker as he deals with the consequences of his secret identity being revealed and explores the multiverse with the help of Doctor Strange.",
                    Instructor = "Jon Watts",
                    ReleaseDate = new DateTime(2021, 12, 17),
                    SuperheroId = _ids[2]
                },
                new Movie
                {
                    Id = Guid.NewGuid(),
                    Title = "The Amazing Spider-Man",
                    Description = "The Amazing Spider-Man is a 2012 American superhero film based on the Marvel Comics character Spider-Man. It is the fourth theatrical Spider-Man film produced by Columbia Pictures and Marvel Entertainment, and a reboot of Sam Raimi's Spider-Man trilogy. The film tells the story of Peter Parker, a high school student who gains spider-like abilities and becomes the superhero Spider-Man.",
                    Instructor = "Marc Webb",
                    ReleaseDate = new DateTime(2012, 7, 3),
                    SuperheroId = _ids[2]
                },
                new Movie
                {
                    Id = Guid.NewGuid(),
                    Title = "Spider-Man",
                    Description = "Spider-Man is a 2002 American superhero film directed by Sam Raimi. It is based on the Marvel Comics character Spider-Man and tells the origin story of Peter Parker, a high school student who develops spider-like abilities after being bitten by a genetically-engineered spider. The film follows Peter as he learns to use his powers and faces off against the Green Goblin, a villainous alter ego of Norman Osborn.",
                    Instructor = "Sam Raimi",
                    ReleaseDate = new DateTime(2002, 5, 3),
                    SuperheroId = _ids[2]
                });
        }
    }
}
