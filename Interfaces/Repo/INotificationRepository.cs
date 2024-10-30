using BlazorApp1.Models;

namespace BlazorApp1.Interfaces.Repo
{
    public interface INotificationRepository : IRepository<Notification>
    {
        Task<IEnumerable<Notification>> GetByRecipientIdAsync(int recipientId);
    }
}
