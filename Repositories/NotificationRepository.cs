using BlazorApp1.Data;
using BlazorApp1.Interfaces.Repo;
using BlazorApp1.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Task = System.Threading.Tasks.Task;

namespace BlazorApp1.Repositories
{
    public class NotificationRepository : INotificationRepository
    {
        private readonly ApplicationDbContext _context;

        public NotificationRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Notification>> GetAllAsync()
        {
            return await _context.Notifications.Include(n => n.Recipient).ToListAsync();
        }

        public async Task<Notification> GetByIdAsync(int id)
        {
            return await _context.Notifications
                .Include(n => n.Recipient)
                .FirstOrDefaultAsync(n => n.ID == id);
        }

        public async Task<IEnumerable<Notification>> GetByRecipientIdAsync(int recipientId)
        {
            return await _context.Notifications
                .Where(n => n.RecipientId == recipientId)
                .ToListAsync();
        }

        public async Task AddAsync(Notification entity)
        {
            await _context.Notifications.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Notification entity)
        {
            _context.Notifications.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _context.Notifications.FindAsync(id);
            if (entity != null)
            {
                _context.Notifications.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
