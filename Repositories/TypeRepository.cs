using BlazorApp1.Data;
using BlazorApp1.Interfaces.Repo;
using BlazorApp1.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Task = System.Threading.Tasks.Task;
using Type = BlazorApp1.Models.Type;

namespace BlazorApp1.Repositories
{
    public class TypeRepository : ITypeRepository
    {
        private readonly ApplicationDbContext _context;

        public TypeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Type>> GetAllAsync()
        {
            return await _context.Types.ToListAsync();
        }

        public async Task<Type> GetByIdAsync(int id)
        {
            return await _context.Types.FindAsync(id);
        }

        public async Task AddAsync(Type entity)
        {
            await _context.Types.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Type entity)
        {
            _context.Types.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _context.Types.FindAsync(id);
            if (entity != null)
            {
                _context.Types.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Type>> GetAllTypesAsync()
        {
            return await GetAllAsync();
        }

        public async Task<Type> GetTypeByIdAsync(int id)
        {
            return await GetByIdAsync(id);
        }
    }
}
