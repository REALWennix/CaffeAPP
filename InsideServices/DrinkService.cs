using BlazorApp1.Interfaces.Repo;
using BlazorApp1.Interfaces.Services;
using BlazorApp1.Models;
using Task = System.Threading.Tasks.Task;

namespace BlazorApp1.InsideServices
{
    public class DrinkService : IDrinkService
    {
        private readonly IDrinkRepository _drinkRepository;

        public DrinkService(IDrinkRepository drinkRepository)
        {
            _drinkRepository = drinkRepository;
        }

        public async Task<IEnumerable<Drink>> GetAllDrinksAsync()
        {
            return await _drinkRepository.GetAllAsync();
        }

        public async Task<Drink> GetDrinkByIdAsync(int id)
        {
            return await _drinkRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Drink>> GetDrinksByPersonIdAsync(int personId)
        {
            return await _drinkRepository.GetByPersonIdAsync(personId);
        }

        public async Task AddDrinkAsync(Drink drink)
        {
            await _drinkRepository.AddAsync(drink);
        }

        public async Task UpdateDrinkAsync(Drink drink)
        {
            await _drinkRepository.UpdateAsync(drink);
        }

        public async Task DeleteDrinkAsync(int id)
        {
            await _drinkRepository.DeleteAsync(id);
        }
    }
}
