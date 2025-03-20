using Microsoft.EntityFrameworkCore;
using ValorantApi.Data;
using ValorantApi.Repositories;
using ValorantApi.Repositories.Interfaces;
using ValorantApi.Services;
using ValorantApi.Services.Interfaces;

namespace ValorantApi.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigurePersistence(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("Sqlite");
            services.AddDbContext<AppDbContext>(options => options.UseSqlite(connectionString));

            services.AddScoped<IJogadorRepository, JogadorRepository>();
        }

        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddScoped<IJogadorService, JogadorService>();
        }
    }
}
