using BlazorApp1.Models;

namespace BlazorApp1.Interfaces.Repo
{
    public interface IDrinkRepository : IRepository<Drink>
    {
        Task<IEnumerable<Drink>> GetByPersonIdAsync(int personId);
    }
}
