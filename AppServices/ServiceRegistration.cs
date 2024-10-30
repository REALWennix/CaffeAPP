using BlazorApp1.InsideServices;
using BlazorApp1.Interfaces.Repo;
using BlazorApp1.Interfaces.Services;
using BlazorApp1.Repositories;

namespace BlazorApp1.Services
{
    public static class ServiceRegistration
    {
        public static void RegisterServices(this IServiceCollection services)
        {

            services.AddScoped<IPersonRepository, PersonRepository>();
            services.AddScoped<ITaskRepository, TaskRepository>();
            services.AddScoped<ITypeRepository, TypeRepository>();
            services.AddScoped<ITaskAssignmentRepository, TaskAssignmentRepository>();
            services.AddScoped<INotificationRepository, NotificationRepository>(); 
            services.AddScoped<IDrinkRepository, DrinkRepository>();
            services.AddScoped<IInvitationRepository, InvitationRepository>();

            services.AddScoped<IPersonService, PersonService>();
            services.AddScoped<IDrinkService, DrinkService>();
            services.AddScoped<IInvitationService, InvitationService>();
            services.AddScoped<INotificationService, NotificationService>();
            services.AddScoped<ITaskAssignmentService, TaskAssignmentService>();
            services.AddScoped<ITaskService, TaskService>();
            services.AddScoped<ITypeService, TypeService>();
        }
    }
}
