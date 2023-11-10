using Contoso.Interactors.Abstractions.Videos;
using Microsoft.Extensions.DependencyInjection;

namespace Contoso.Videos.UseCases;

public static class DependencyContainer
{
    public static IServiceCollection AddVideoUseCases(this IServiceCollection services)
    {
        services.AddScoped<IAddVideoInputPort, AddVideo>();
        return services;
    }
}