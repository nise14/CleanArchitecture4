using Microsoft.Extensions.DependencyInjection;

namespace Contoso.Builders;

public static class DependencyContainer
{
    public static IServiceCollection AddBuilders(this IServiceCollection services)
    {
        services.AddScoped<VideoBuilder>();
        return services;

    }
}