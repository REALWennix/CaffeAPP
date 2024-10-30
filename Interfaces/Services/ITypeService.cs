using BlazorApp1.Models;
using Task = System.Threading.Tasks.Task;
namespace BlazorApp1.Interfaces.Services
{
    public interface ITypeService
    {
        Task<IEnumerable<Models.Type>> GetAllTypesAsync();
        Task<Models.Type> GetTypeByIdAsync(int id);
        Task AddTypeAsync(Models.Type type);
        Task UpdateTypeAsync(Models.Type type);
        Task DeleteTypeAsync(int id);
    }
}
