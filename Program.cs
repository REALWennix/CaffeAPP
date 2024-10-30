using BlazorApp1.Components;
using BlazorApp1.Services;

namespace BlazorApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            try
            {
                builder.Services.ConfigureDatabase(builder.Configuration.GetConnectionString("DefaultConnection"));
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            builder.Services.ConfigureServices();
            builder.Services.RegisterServices();

            var app = builder.Build();

            app.ConfigureMiddleware(app.Environment);

            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode();

            app.Run();
        }
    }
}
