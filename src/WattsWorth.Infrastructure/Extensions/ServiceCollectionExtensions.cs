using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WattsWorth.Infrastructure.Data;
using WattsWorth.Infrastructure.Repositories;

namespace WattsWorth.Infrastructure.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddInfrastructureLayer(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlite(configuration.GetConnectionString("SQLiteConnection")));

        // Register repositories
        services.AddScoped<IPayBracketRepository, PayBracketRepository>();

        return services;
    }
}