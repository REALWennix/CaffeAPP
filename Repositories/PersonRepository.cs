using BlazorApp1.Data;
using BlazorApp1.Interfaces.Repo;
using BlazorApp1.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Task = System.Threading.Tasks.Task;

namespace BlazorApp1.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly ApplicationDbContext _context;

        public PersonRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Person>> GetAllAsync()
        {
            return await _context.Person.ToListAsync();
        }

        public async Task<Person> GetByIdAsync(int id)
        {
            return await _context.Person.FindAsync(id);
        }

        public async Task AddAsync(Person entity)
        {
            await _context.Person.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Person entity)
        {
            _context.Person.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _context.Person.FindAsync(id);
            if (entity != null)
            {
                _context.Person.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Person>> GetAllPersonsAsync()
        {
            return await _context.Person.ToListAsync();
        }

        public async Task<Person> GetPersonByIdAsync(int id)
        {
            return await _context.Person.FindAsync(id);
        }
    }
}

