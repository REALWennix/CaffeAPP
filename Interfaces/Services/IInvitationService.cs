using BlazorApp1.Models;
using Task = System.Threading.Tasks.Task;

namespace BlazorApp1.Interfaces.Services
{
    public interface IInvitationService
    {
        Task<IEnumerable<Invitation>> GetAllInvitationsAsync();
        Task<Invitation> GetInvitationByIdAsync(int id);
        Task<IEnumerable<Invitation>> GetInvitationsByInviterIdAsync(int inviterId);
        Task<IEnumerable<Invitation>> GetInvitationsByInviteeIdAsync(int inviteeId);
        Task AddInvitationAsync(Invitation invitation);
        Task UpdateInvitationAsync(Invitation invitation);
        Task DeleteInvitationAsync(int id);
    }
}
