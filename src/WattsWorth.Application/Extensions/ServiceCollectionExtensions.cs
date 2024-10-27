using Microsoft.Extensions.DependencyInjection;
using WattsWorth.Application.Features.CalculateCost;

namespace WattsWorth.Application.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddApplicationLayer(this IServiceCollection services)
    {
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(CalculateCostHandler).Assembly));
        return services;
    }
}
