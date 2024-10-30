using Microsoft.AspNetCore.Builder;
namespace BlazorApp1.Services
{
    public static class MiddlewareConfiguration
    {
        public static void ConfigureMiddleware(this IApplicationBuilder app, IHostEnvironment env)
        {
            if (!env.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseAntiforgery();
        }
    }
}
