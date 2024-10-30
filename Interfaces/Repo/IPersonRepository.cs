using BlazorApp1.Models;

namespace BlazorApp1.Interfaces.Repo
{
    public interface IPersonRepository : IRepository<Person>
    {
        Task<IEnumerable<Person>> GetAllPersonsAsync();
        Task<Person> GetPersonByIdAsync(int id);
    }
}
