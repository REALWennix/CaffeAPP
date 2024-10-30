using BlazorApp1.Interfaces.Repo;
using BlazorApp1.Interfaces.Services;

namespace BlazorApp1.InsideServices
{
    public class TaskService : ITaskService
    {
        private readonly ITaskRepository _taskRepository;

        public TaskService(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public async Task<IEnumerable<Models.Task>> GetAllTasksAsync()
        {
            return await _taskRepository.GetAllAsync();
        }

        public async Task<Models.Task> GetTaskByIdAsync(int id)
        {
            return await _taskRepository.GetByIdAsync(id);
        }

        public async Task AddTaskAsync(Models.Task task)
        {
            await _taskRepository.AddAsync(task);
        }

        public async Task UpdateTaskAsync(Models.Task task)
        {
            await _taskRepository.UpdateAsync(task);
        }

        public async Task DeleteTaskAsync(int id)
        {
            await _taskRepository.DeleteAsync(id);
        }
    }
}
