using BlazorApp1.Models;
using Task = System.Threading.Tasks.Task;
namespace BlazorApp1.Interfaces.Services
{
    public interface IPersonService
    {
        Task<IEnumerable<Person>> GetAllPersonsAsync();
        Task<Person> GetPersonByIdAsync(int id);
        Task AddPersonAsync(Person person);
        Task UpdatePersonAsync(Person person);
        Task DeletePersonAsync(int id);
    }
}
