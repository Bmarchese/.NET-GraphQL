namespace GraphQLHotChocolate.Models.Payload
{
    public record SuperHeroPayload(SuperHero superHero);
    public record MoviePayload(Guid Id, string Title, string Description, string Instructor, DateTime ReleaseDate, Guid SuperheroId);
    public record SuperPowerPayload(Guid Id, string Superpower, string Description, Guid SuperheroId);
}
