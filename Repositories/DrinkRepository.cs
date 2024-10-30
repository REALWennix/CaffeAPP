using BlazorApp1.Data;
using BlazorApp1.Interfaces.Repo;
using BlazorApp1.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Task = System.Threading.Tasks.Task;

namespace BlazorApp1.Repositories
{
    public class DrinkRepository : IDrinkRepository
    {
        private readonly ApplicationDbContext _context;

        public DrinkRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Drink>> GetAllAsync()
        {
            return await _context.Drinks.Include(d => d.Person).Include(d => d.Type).ToListAsync();
        }

        public async Task<Drink> GetByIdAsync(int id)
        {
            return await _context.Drinks
                .Include(d => d.Person)
                .Include(d => d.Type)
                .FirstOrDefaultAsync(d => d.ID == id);
        }

        public async Task<IEnumerable<Drink>> GetByPersonIdAsync(int personId)
        {
            return await _context.Drinks
                .Where(d => d.IdPerson == personId)
                .Include(d => d.Person)
                .Include(d => d.Type)
                .ToListAsync();
        }

        public async Task AddAsync(Drink entity)
        {
            await _context.Drinks.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Drink entity)
        {
            _context.Drinks.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _context.Drinks.FindAsync(id);
            if (entity != null)
            {
                _context.Drinks.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
