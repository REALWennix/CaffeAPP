using BlazorApp1.Models;

namespace BlazorApp1.Interfaces.Repo
{
    public interface IInvitationRepository : IRepository<Invitation>
    {
        Task<IEnumerable<Invitation>> GetByInviterIdAsync(int inviterId);
        Task<IEnumerable<Invitation>> GetByInviteeIdAsync(int inviteeId);
    }
}
