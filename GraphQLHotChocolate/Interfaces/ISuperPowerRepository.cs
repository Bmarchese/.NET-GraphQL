using GraphQLHotChocolate.Models;

namespace GraphQLHotChocolate.Interfaces
{
    public interface ISuperPowerRepository
    {
        IQueryable<SuperPower> GetAll();
        Task<SuperPower> AddSuperPower(SuperPower power);
        Task<SuperPower> UpdateSuperPower(SuperPower power);
        Task<SuperPower> DeleteSuperPower(Guid idPower);
    }
}
