using BlazorApp1.Interfaces.Repo;
using BlazorApp1.Interfaces.Services;
using BlazorApp1.Models;
using Task = System.Threading.Tasks.Task;

namespace BlazorApp1.InsideServices
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _personRepository;

        public PersonService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public async Task<IEnumerable<Person>> GetAllPersonsAsync()
        {
            return await _personRepository.GetAllAsync();
        }

        public async Task<Person> GetPersonByIdAsync(int id)
        {
            return await _personRepository.GetByIdAsync(id);
        }

        public async Task AddPersonAsync(Person person)
        {
            await _personRepository.AddAsync(person);
        }

        public async Task UpdatePersonAsync(Person person)
        {
            await _personRepository.UpdateAsync(person);
        }

        public async Task DeletePersonAsync(int id)
        {
            await _personRepository.DeleteAsync(id);
        }
    }
}
