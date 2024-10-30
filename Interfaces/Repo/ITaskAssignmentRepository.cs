using BlazorApp1.Models;

namespace BlazorApp1.Interfaces.Repo
{
    public interface ITaskAssignmentRepository : IRepository<TaskAssignment>
    {
        Task<IEnumerable<TaskAssignment>> GetAllTaskAssignmentsAsync();
        Task<TaskAssignment> GetTaskAssignmentByIdAsync(int id);
    }
}
