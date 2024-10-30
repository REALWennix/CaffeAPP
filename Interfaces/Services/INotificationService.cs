using BlazorApp1.Models;
using Task = System.Threading.Tasks.Task;

namespace BlazorApp1.Interfaces.Services
{
    public interface INotificationService
    {
        Task<IEnumerable<Notification>> GetAllNotificationsAsync();
        Task<Notification> GetNotificationByIdAsync(int id);
        Task<IEnumerable<Notification>> GetNotificationsByRecipientIdAsync(int recipientId);
        Task AddNotificationAsync(Notification notification);
        Task UpdateNotificationAsync(Notification notification);
        Task DeleteNotificationAsync(int id);
    }
}
