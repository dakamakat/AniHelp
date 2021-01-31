using Application.Common.Interfaces;
using Infrastructure.Identity;
using Infrastructure.Persistence;
using Infrastructure.Services.JWTTokenService;
using Infrastructure.Services.KitsuApiService.Contracts;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;

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


            // ASP.NET Core Identity
            services.AddIdentity<ApplicationUser, IdentityRole>(options =>
            {
                options.User.RequireUniqueEmail = false;
                options.Password.RequiredLength = 8;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireLowercase = true;
                options.Password.RequireUppercase = false;
                options.Password.RequireDigit = true;
            })
            .AddEntityFrameworkStores<AniHelpDbContext>()
            .AddDefaultTokenProviders();

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                    .AddJwtBearer(options =>
                    {
                        //This option set false only for testing ir real app must be set true
                        options.RequireHttpsMetadata = false;

                        options.TokenValidationParameters = new TokenValidationParameters
                        {
                            // Specifies whether the publisher will be validated when validating the token
                            ValidateIssuer = true,
                            // A string representing the publisher
                            ValidIssuer = AuthOptions.ISSUER,

                            // Whether the consumer of the token will be validated
                            ValidateAudience = true,

                            // Token consumer setting
                            ValidAudience = AuthOptions.AUDIENCE,

                            // Whether the lifetime will be validated
                            ValidateLifetime = true,

                            // Setting security key
                            IssuerSigningKey = AuthOptions.GetSymmetricSecurityKey(),

                            // Validate security key
                            ValidateIssuerSigningKey = true,
                        };
                    });

            services.AddScoped<IIdentityService, IdentityService>();

            services.AddScoped<IAniHelpDbContext>(provider => provider.GetService<AniHelpDbContext>());

            services.AddScoped<IKistuRequestService, KitsuApiRequestService>();

            return services;
        }
    }
}
