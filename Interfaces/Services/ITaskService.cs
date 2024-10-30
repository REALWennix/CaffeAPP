namespace BlazorApp1.Interfaces.Services
{
    public interface ITaskService
    {
        Task<IEnumerable<Models.Task>> GetAllTasksAsync();
        Task<Models.Task> GetTaskByIdAsync(int id);
        Task AddTaskAsync(Models.Task task);
        Task UpdateTaskAsync(Models.Task task);
        Task DeleteTaskAsync(int id);
    }
}
