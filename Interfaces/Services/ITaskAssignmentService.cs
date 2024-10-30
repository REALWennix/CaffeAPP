using BlazorApp1.Models;
using Task = System.Threading.Tasks.Task;

namespace BlazorApp1.Interfaces.Services
{
    public interface ITaskAssignmentService
    {
        Task<IEnumerable<TaskAssignment>> GetAllTaskAssignmentsAsync();
        Task<TaskAssignment> GetTaskAssignmentByIdAsync(int id);
        Task AddTaskAssignmentAsync(TaskAssignment taskAssignment);
        Task UpdateTaskAssignmentAsync(TaskAssignment taskAssignment);
        Task DeleteTaskAssignmentAsync(int id);
    }
}
