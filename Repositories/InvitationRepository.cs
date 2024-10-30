using BlazorApp1.Data;
using BlazorApp1.Interfaces.Repo;
using BlazorApp1.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Task = System.Threading.Tasks.Task;

namespace BlazorApp1.Repositories
{
    public class InvitationRepository : IInvitationRepository
    {
        private readonly ApplicationDbContext _context;

        public InvitationRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Invitation>> GetAllAsync()
        {
            return await _context.Invitations.Include(i => i.Inviter).Include(i => i.Invitee).ToListAsync();
        }

        public async Task<Invitation> GetByIdAsync(int id)
        {
            return await _context.Invitations
                .Include(i => i.Inviter)
                .Include(i => i.Invitee)
                .FirstOrDefaultAsync(i => i.ID == id);
        }

        public async Task<IEnumerable<Invitation>> GetByInviterIdAsync(int inviterId)
        {
            return await _context.Invitations
                .Where(i => i.InviterId == inviterId)
                .Include(i => i.Invitee)
                .ToListAsync();
        }

        public async Task<IEnumerable<Invitation>> GetByInviteeIdAsync(int inviteeId)
        {
            return await _context.Invitations
                .Where(i => i.InviteeId == inviteeId)
                .Include(i => i.Inviter)
                .ToListAsync();
        }

        public async Task AddAsync(Invitation entity)
        {
            await _context.Invitations.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Invitation entity)
        {
            _context.Invitations.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _context.Invitations.FindAsync(id);
            if (entity != null)
            {
                _context.Invitations.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
