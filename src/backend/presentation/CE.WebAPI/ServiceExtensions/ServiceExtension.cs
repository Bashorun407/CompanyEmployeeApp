using CE.Application.Common;
using CE.Persistence.Repositories.Common;

namespace CE.WebAPI.ServiceExtensions
{
    public static class ServiceExtension
    {
        public static void ConfigureRepositoryManager(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryManager, RepositoryManager>();
        }
    }
}
