namespace BlazorApp1.Services
{
    public static class ServiceConfiguration
    {
        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddRazorComponents()
                .AddInteractiveServerComponents();

        }
    }
}
