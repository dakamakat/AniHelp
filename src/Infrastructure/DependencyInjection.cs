using Application.Common.Interfaces;
using Infrastructure.Persistence;
using Infrastructure.Services.KitsuApiService.Contracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AniHelpDbContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("MSSQLConnection"),
                    b => b.MigrationsAssembly(typeof(AniHelpDbContext).Assembly.FullName)));

            services.AddScoped<IAniHelpDbContext>(provider => provider.GetService<AniHelpDbContext>());

            services.AddScoped<IKistuRequestService, KitsuApiRequestService>();

            return services;
        }
    }
}
