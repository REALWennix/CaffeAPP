using BlazorApp1.Models;

namespace BlazorApp1.Interfaces.Repo
{
    public interface ITaskRepository : IRepository<Models.Task>
    {
        Task<IEnumerable<Models.Task>> GetAllTasksAsync();
        Task<Models.Task> GetTaskByIdAsync(int id);
    }
}
