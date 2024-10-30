using BlazorApp1.Data;
using BlazorApp1.Interfaces.Repo;
using BlazorApp1.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Task = System.Threading.Tasks.Task;

namespace BlazorApp1.Repositories
{
    public class TaskAssignmentRepository : ITaskAssignmentRepository
    {
        private readonly ApplicationDbContext _context;

        public TaskAssignmentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TaskAssignment>> GetAllAsync()
        {
            return await _context.TaskAssignments.Include(ta => ta.Task).Include(ta => ta.AssignedPerson).ToListAsync();
        }

        public async Task<TaskAssignment> GetByIdAsync(int id)
        {
            return await _context.TaskAssignments.Include(ta => ta.Task).Include(ta => ta.AssignedPerson).FirstOrDefaultAsync(ta => ta.ID == id);
        }

        public async Task AddAsync(TaskAssignment entity)
        {
            await _context.TaskAssignments.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(TaskAssignment entity)
        {
            _context.TaskAssignments.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _context.TaskAssignments.FindAsync(id);
            if (entity != null)
            {
                _context.TaskAssignments.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<TaskAssignment>> GetAllTaskAssignmentsAsync()
        {
            return await _context.TaskAssignments.Include(ta => ta.Task).Include(ta => ta.AssignedPerson).ToListAsync();
        }

        public async Task<TaskAssignment> GetTaskAssignmentByIdAsync(int id)
        {
            return await _context.TaskAssignments.Include(ta => ta.Task).Include(ta => ta.AssignedPerson).FirstOrDefaultAsync(ta => ta.ID == id);
        }
    }
}
