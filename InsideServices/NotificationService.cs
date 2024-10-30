using BlazorApp1.Interfaces.Repo;
using BlazorApp1.Interfaces.Services;
using BlazorApp1.Models;
using Task = System.Threading.Tasks.Task;

namespace BlazorApp1.InsideServices
{
    public class NotificationService : INotificationService
    {
        private readonly INotificationRepository _notificationRepository;

        public NotificationService(INotificationRepository notificationRepository)
        {
            _notificationRepository = notificationRepository;
        }

        public async Task<IEnumerable<Notification>> GetAllNotificationsAsync()
        {
            return await _notificationRepository.GetAllAsync();
        }

        public async Task<Notification> GetNotificationByIdAsync(int id)
        {
            return await _notificationRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Notification>> GetNotificationsByRecipientIdAsync(int recipientId)
        {
            return await _notificationRepository.GetByRecipientIdAsync(recipientId);
        }

        public async Task AddNotificationAsync(Notification notification)
        {
            await _notificationRepository.AddAsync(notification);
        }

        public async Task UpdateNotificationAsync(Notification notification)
        {
            await _notificationRepository.UpdateAsync(notification);
        }

        public async Task DeleteNotificationAsync(int id)
        {
            await _notificationRepository.DeleteAsync(id);
        }
    }
}
