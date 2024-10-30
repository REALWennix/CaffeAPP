using BlazorApp1.Models;
using Task = System.Threading.Tasks.Task;

namespace BlazorApp1.Interfaces.Services
{
    public interface IDrinkService
    {
        Task<IEnumerable<Drink>> GetAllDrinksAsync();
        Task<Drink> GetDrinkByIdAsync(int id);
        Task<IEnumerable<Drink>> GetDrinksByPersonIdAsync(int personId);
        Task AddDrinkAsync(Drink drink);
        Task UpdateDrinkAsync(Drink drink);
        Task DeleteDrinkAsync(int id);
    }
}
