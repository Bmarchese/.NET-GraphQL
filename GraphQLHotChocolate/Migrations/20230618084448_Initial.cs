using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GraphQLHotChocolate.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Superheroes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Height = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Superheroes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Instructor = table.Column<string>(type: "TEXT", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    SuperheroId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Movies_Superheroes_SuperheroId",
                        column: x => x.SuperheroId,
                        principalTable: "Superheroes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Superpowers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Superpower = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    SuperheroId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Superpowers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Superpowers_Superheroes_SuperheroId",
                        column: x => x.SuperheroId,
                        principalTable: "Superheroes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Superheroes",
                columns: new[] { "Id", "Description", "Height", "Name" },
                values: new object[,]
                {
                    { new Guid("107aa9b9-b152-42d8-94b6-53ec14185598"), "Luke Skywalker was a Tatooine farmboy who rose from humble beginnings to become one of the greatest Jedi the galaxy has ever known. Along with his friends Princess Leia and Han Solo, Luke battled the evil Empire, discovered the truth of his parentage, and ended the tyranny of the Sith.", 1.7, "Luke Skywalker" },
                    { new Guid("c26365a9-f493-4041-a977-01c05041ea43"), "Spider-Man, also known as Peter Parker, is a teenage superhero with the proportionate strength, speed, and agility of a spider. He can cling to walls and has a spider-sense that alerts him to danger. Spider-Man uses his powers to protect New York City from various supervillains.", 1.78, "Spider-Man" },
                    { new Guid("c8d0cd36-3605-4454-b8c8-a5d7bced1d2a"), "Batman was originally introduced as a ruthless vigilante who frequently killed or maimed criminals, but evolved into a character with a stringent moral code and strong sense of justice. Unlike most superheroes, Batman does not possess any superpowers, instead relying on his intellect, fighting skills, and wealth.", 1.9299999999999999, "Batman" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Instructor", "ReleaseDate", "SuperheroId", "Title" },
                values: new object[,]
                {
                    { new Guid("0362889d-d800-474b-9b6d-a2f8e44e9cf7"), "Batman Begins is a 2005 superhero film directed by Christopher Nolan and written by Nolan and David S. Goyer. Based on the DC Comics character Batman, it stars Christian Bale as Bruce Wayne / Batman, with Michael Caine, Liam Neeson, Katie Holmes, Gary Oldman,", "Christopher Nolan", new DateTime(2005, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c8d0cd36-3605-4454-b8c8-a5d7bced1d2a"), "Batman Begins" },
                    { new Guid("1dc5c062-d7bf-44fe-b458-0c45c8fc06ad"), "The Dark Knight Rises is a 2012 superhero film directed by Christopher Nolan, who co-wrote the screenplay with his brother Jonathan Nolan, and the story with David S. Goyer.", "Christopher Nolan", new DateTime(2012, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c8d0cd36-3605-4454-b8c8-a5d7bced1d2a"), "The Dark Knight Rises" },
                    { new Guid("221f5718-f525-42a7-903a-8e40b7ae0df4"), "Return of the Jedi (also known as Star Wars: Episode VI – Return of the Jedi) is a 1983 American epic space opera film directed by Richard Marquand. The screenplay is by Lawrence Kasdan and George Lucas from a story by Lucas, who was also the executive producer.", "Richard Marquand", new DateTime(1983, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("107aa9b9-b152-42d8-94b6-53ec14185598"), "Star Wars: Episode VI – Return of the Jedi" },
                    { new Guid("3729a154-03b4-48fe-971a-91b2b719a5ac"), "Star Wars (retroactively titled Star Wars: Episode IV – A New Hope) is a 1977 American epic space opera film written and directed by George Lucas, produced by Lucasfilm and distributed by 20th Century Fox.", "George Lucas", new DateTime(1977, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("107aa9b9-b152-42d8-94b6-53ec14185598"), "Star Wars: Episode IV – A New Hope" },
                    { new Guid("8091d052-0044-4748-958f-f2c0fc340880"), "The Amazing Spider-Man is a 2012 American superhero film based on the Marvel Comics character Spider-Man. It is the fourth theatrical Spider-Man film produced by Columbia Pictures and Marvel Entertainment, and a reboot of Sam Raimi's Spider-Man trilogy. The film tells the story of Peter Parker, a high school student who gains spider-like abilities and becomes the superhero Spider-Man.", "Marc Webb", new DateTime(2012, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c26365a9-f493-4041-a977-01c05041ea43"), "The Amazing Spider-Man" },
                    { new Guid("89f88e7f-2925-4cd5-9d30-49f6fb99c263"), "Spider-Man: Homecoming is a 2017 American superhero film based on the Marvel Comics character Spider-Man. It is the second reboot of the Spider-Man film franchise and the sixteenth film in the Marvel Cinematic Universe (MCU). The movie follows the story of Peter Parker as he navigates high school life and his newfound abilities as Spider-Man, while facing the villainous Vulture.", "Jon Watts", new DateTime(2017, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c26365a9-f493-4041-a977-01c05041ea43"), "Spider-Man: Homecoming" },
                    { new Guid("9eba5008-29f4-4798-98d6-8ff527c1c252"), "The Empire Strikes Back (also known as Star Wars: Episode V – The Empire Strikes Back) is a 1980 American epic space opera film directed by Irvin Kershner and written by Leigh Brackett and Lawrence Kasdan, based on a story by George Lucas.", "Irvin Kershner", new DateTime(1980, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("107aa9b9-b152-42d8-94b6-53ec14185598"), "Star Wars: Episode V – The Empire Strikes Back" },
                    { new Guid("b778f283-e5cc-42e6-af6a-aa2fd7763494"), "Spider-Man is a 2002 American superhero film directed by Sam Raimi. It is based on the Marvel Comics character Spider-Man and tells the origin story of Peter Parker, a high school student who develops spider-like abilities after being bitten by a genetically-engineered spider. The film follows Peter as he learns to use his powers and faces off against the Green Goblin, a villainous alter ego of Norman Osborn.", "Sam Raimi", new DateTime(2002, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c26365a9-f493-4041-a977-01c05041ea43"), "Spider-Man" },
                    { new Guid("bbc07d5f-d12b-4216-80cc-12f63bae5c4e"), "Spider-Man: No Way Home is an upcoming American superhero film based on the Marvel Comics character Spider-Man. It is the third film in the Spider-Man: Homecoming trilogy and the 27th film in the Marvel Cinematic Universe (MCU). The movie will continue the story of Peter Parker as he deals with the consequences of his secret identity being revealed and explores the multiverse with the help of Doctor Strange.", "Jon Watts", new DateTime(2021, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c26365a9-f493-4041-a977-01c05041ea43"), "Spider-Man: No Way Home" },
                    { new Guid("c3b10d28-2335-4677-ba4e-4806b2186c4c"), "Spider-Man: Far From Home is a 2019 American superhero film based on the Marvel Comics character Spider-Man. It is the sequel to Spider-Man: Homecoming and the 23rd film in the Marvel Cinematic Universe (MCU). In the movie, Peter Parker embarks on a school trip to Europe but is recruited by Nick Fury to help fight against the Elementals, alongside the mysterious superhero Mysterio.", "Jon Watts", new DateTime(2019, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c26365a9-f493-4041-a977-01c05041ea43"), "Spider-Man: Far From Home" },
                    { new Guid("ce327da2-06bf-4921-9356-2ff92da6bec6"), "The Batman is a reboot of the Batman film franchise. The film was directed by Matt Reeves, who wrote the screenplay with Peter Craig.", "Matt Reeves", new DateTime(2022, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c8d0cd36-3605-4454-b8c8-a5d7bced1d2a"), "The Batman" },
                    { new Guid("dfb37a4f-5d14-4c90-8806-13315031925b"), "The Dark Knight is a 2008 superhero film directed, produced, and co-written by Christopher Nolan. Based on the DC Comics character Batman, the film is the second installment of Nolan's The Dark Knight Trilogy and a sequel to 2005's Batman Begins, starring Christian Bale and supported by Michael Caine, Heath Ledger, Gary Oldman, Aaron Eckhart, Maggie Gyllenhaal, and Morgan Freeman.", "Christopher Nolan", new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c8d0cd36-3605-4454-b8c8-a5d7bced1d2a"), "The Dark Knight" }
                });

            migrationBuilder.InsertData(
                table: "Superpowers",
                columns: new[] { "Id", "Description", "SuperheroId", "Superpower" },
                values: new object[,]
                {
                    { new Guid("16d0b40f-7fe4-4573-b572-f7dc02b42777"), "He's always a step ahead.", new Guid("c8d0cd36-3605-4454-b8c8-a5d7bced1d2a"), "Intellect." },
                    { new Guid("2ee5d9c3-8176-4f1d-ad32-8782ad954628"), "Spider-Man's spider-sense grants him an advanced warning system, allowing him to sense danger before it occurs, including incoming attacks, imminent threats, or hidden enemies.", new Guid("c26365a9-f493-4041-a977-01c05041ea43"), "Spider-Sense" },
                    { new Guid("39fa1b01-669a-4544-858d-eacd4d2c6a54"), "Sublime fighting skills.", new Guid("c8d0cd36-3605-4454-b8c8-a5d7bced1d2a"), "Fighting" },
                    { new Guid("448723b4-dc81-412b-8c76-a41490df729c"), "Luke Skywalker has the ability to move objects with his mind. He can manipulate and control objects using telekinesis, allowing him to lift, push, or pull things without physical contact.", new Guid("107aa9b9-b152-42d8-94b6-53ec14185598"), "Telekinesis" },
                    { new Guid("4b3ab9d0-607f-43c3-81db-045cc36a37b8"), "He got a lot of money", new Guid("c8d0cd36-3605-4454-b8c8-a5d7bced1d2a"), "Wealth." },
                    { new Guid("57dbab0e-5f00-4cfc-b712-f80252ba0b47"), "Spider-Man can generate and shoot strong, adhesive webs from devices he created called web-shooters. He uses these webs to swing through the city, create barriers, restrain enemies, or as a versatile tool in combat and rescue operations.", new Guid("c26365a9-f493-4041-a977-01c05041ea43"), "Web-Slinging" },
                    { new Guid("63cc33fc-7ba2-4ff6-be21-c36c3d2261a6"), "Luke Skywalker possesses the rare ability to project a realistic and powerful image of himself across vast distances. This power allows him to deceive and distract his enemies, giving him an advantage in battles and strategic situations.", new Guid("107aa9b9-b152-42d8-94b6-53ec14185598"), "Force Projection" },
                    { new Guid("78f2bbd0-4aa4-45cd-8711-5f3934501f0c"), "Luke Skywalker is able to deflect fire from a blaster back at the opponent firing. This enables Luke to turn someone else's weapon against them.", new Guid("107aa9b9-b152-42d8-94b6-53ec14185598"), "Deflect blaster power." },
                    { new Guid("810ea0dd-052c-47b1-b291-a48229876744"), "Spider-Man possesses exceptional agility and reflexes, surpassing those of a regular human. He can perform acrobatic maneuvers, dodge attacks with ease, and move swiftly in various environments, making him incredibly difficult to hit or capture.", new Guid("c26365a9-f493-4041-a977-01c05041ea43"), "Increased Agility" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Movies_SuperheroId",
                table: "Movies",
                column: "SuperheroId");

            migrationBuilder.CreateIndex(
                name: "IX_Superpowers_SuperheroId",
                table: "Superpowers",
                column: "SuperheroId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Superpowers");

            migrationBuilder.DropTable(
                name: "Superheroes");
        }
    }
}
