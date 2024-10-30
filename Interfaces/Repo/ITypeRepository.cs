using BlazorApp1.Models;
using Type = BlazorApp1.Models.Type;

namespace BlazorApp1.Interfaces.Repo
{
    public interface ITypeRepository : IRepository<Type>
    {
        Task<IEnumerable<Type>> GetAllTypesAsync();
        Task<Type> GetTypeByIdAsync(int id);
    }
}
