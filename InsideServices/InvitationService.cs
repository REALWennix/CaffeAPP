using BlazorApp1.Interfaces.Repo;
using BlazorApp1.Interfaces.Services;
using BlazorApp1.Models;
using Task = System.Threading.Tasks.Task;

namespace BlazorApp1.InsideServices
{
    public class InvitationService : IInvitationService
    {
        private readonly IInvitationRepository _invitationRepository;

        public InvitationService(IInvitationRepository invitationRepository)
        {
            _invitationRepository = invitationRepository;
        }

        public async Task<IEnumerable<Invitation>> GetAllInvitationsAsync()
        {
            return await _invitationRepository.GetAllAsync();
        }

        public async Task<Invitation> GetInvitationByIdAsync(int id)
        {
            return await _invitationRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Invitation>> GetInvitationsByInviterIdAsync(int inviterId)
        {
            return await _invitationRepository.GetByInviterIdAsync(inviterId);
        }

        public async Task<IEnumerable<Invitation>> GetInvitationsByInviteeIdAsync(int inviteeId)
        {
            return await _invitationRepository.GetByInviteeIdAsync(inviteeId);
        }

        public async Task AddInvitationAsync(Invitation invitation)
        {
            await _invitationRepository.AddAsync(invitation);
        }

        public async Task UpdateInvitationAsync(Invitation invitation)
        {
            await _invitationRepository.UpdateAsync(invitation);
        }

        public async Task DeleteInvitationAsync(int id)
        {
            await _invitationRepository.DeleteAsync(id);
        }
    }
}
