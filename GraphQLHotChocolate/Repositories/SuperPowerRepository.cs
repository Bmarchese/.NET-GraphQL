using GraphQLHotChocolate.Data;
using GraphQLHotChocolate.Interfaces;
using GraphQLHotChocolate.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQLHotChocolate.Repositories
{
    public class SuperPowerRepository : ISuperPowerRepository
    {
        private readonly ApplicationDbContext _context;

        public SuperPowerRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IQueryable<SuperPower> GetAll()
        {
            return _context.Superpowers;
        }

        public async Task<SuperPower> AddSuperPower(SuperPower power)
        {
            await _context.Superpowers.AddAsync(power);
            await _context.SaveChangesAsync();
            return power;
        }

        public async Task<SuperPower> UpdateSuperPower(SuperPower power)
        {
            _context.Superpowers.Update(power);
            await _context.SaveChangesAsync();
            return power;
        }

        public async Task<SuperPower> DeleteSuperPower(Guid idPower)
        {
            var power = _context.Superpowers.First(x => x.Id == idPower);
            _context.Superpowers.Remove(power);
            await _context.SaveChangesAsync();

            return power;
        }
    }
}
