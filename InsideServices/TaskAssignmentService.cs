using BlazorApp1.Interfaces.Repo;
using BlazorApp1.Interfaces.Services;
using BlazorApp1.Models;
using Task = System.Threading.Tasks.Task;

namespace BlazorApp1.InsideServices
{
    public class TaskAssignmentService : ITaskAssignmentService
    {
        private readonly ITaskAssignmentRepository _taskAssignmentRepository;

        public TaskAssignmentService(ITaskAssignmentRepository taskAssignmentRepository)
        {
            _taskAssignmentRepository = taskAssignmentRepository;
        }

        public async Task<IEnumerable<TaskAssignment>> GetAllTaskAssignmentsAsync()
        {
            return await _taskAssignmentRepository.GetAllAsync();
        }

        public async Task<TaskAssignment> GetTaskAssignmentByIdAsync(int id)
        {
            return await _taskAssignmentRepository.GetByIdAsync(id);
        }

        public async Task AddTaskAssignmentAsync(TaskAssignment taskAssignment)
        {
            await _taskAssignmentRepository.AddAsync(taskAssignment);
        }

        public async Task UpdateTaskAssignmentAsync(TaskAssignment taskAssignment)
        {
            await _taskAssignmentRepository.UpdateAsync(taskAssignment);
        }

        public async Task DeleteTaskAssignmentAsync(int id)
        {
            await _taskAssignmentRepository.DeleteAsync(id);
        }
    }
}
