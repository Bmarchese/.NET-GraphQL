namespace GraphQLHotChocolate.Models.Input
{
    public record SuperHeroInput(string Name, string Description, double Height);
    public record SuperHeroUpdateInput(Guid Id, string Name, string Description, double Height);
    public record SuperHeroDeleteInput(Guid Id);
    public record MovieInput(string Title, string Description, string Instructor, DateTime ReleaseDate, Guid SuperheroId);
    public record MovieUpdateInput(Guid Id, string Title, string Description, string Instructor, DateTime ReleaseDate, Guid SuperheroId);
    public record MovieDeleteInput(Guid Id);
    public record SuperPowerInput(string Power, string Description, Guid SuperheroId);
    public record SuperPowerUpdateInput(Guid Id, string Power, string Description, Guid SuperheroId);
    public record SuperPowerDeleteInput(Guid Id);
}
