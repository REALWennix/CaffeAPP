using BlazorApp1.Data;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Services
{
    public static class ServiceExtensions
    {
        public static void ConfigureDatabase(this IServiceCollection services, string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString))
            {
                throw new ArgumentNullException(nameof(connectionString), "Connection string cannot be null or empty.");
            }

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connectionString));
        }
    }
}
