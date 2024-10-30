using BlazorApp1.Interfaces.Repo;
using BlazorApp1.Interfaces.Services;
using BlazorApp1.Models;
using Task = System.Threading.Tasks.Task;
using Type = BlazorApp1.Models.Type;

namespace BlazorApp1.InsideServices
{
    public class TypeService : ITypeService
    {
        private readonly ITypeRepository _typeRepository;

        public TypeService(ITypeRepository typeRepository)
        {
            _typeRepository = typeRepository;
        }

        public async Task<IEnumerable<Type>> GetAllTypesAsync()
        {
            return await _typeRepository.GetAllAsync();
        }

        public async Task<Type> GetTypeByIdAsync(int id)
        {
            return await _typeRepository.GetByIdAsync(id);
        }

        public async Task AddTypeAsync(Type type)
        {
            await _typeRepository.AddAsync(type);
        }

        public async Task UpdateTypeAsync(Type type)
        {
            await _typeRepository.UpdateAsync(type);
        }

        public async Task DeleteTypeAsync(int id)
        {
            await _typeRepository.DeleteAsync(id);
        }
    }
}
