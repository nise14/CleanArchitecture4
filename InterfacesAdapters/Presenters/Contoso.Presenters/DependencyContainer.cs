using Contoso.Interactors.Abstractions.Videos;
using Microsoft.Extensions.DependencyInjection;

namespace Contoso.Presenters;

public static class DependencyContainer
{
    public static IServiceCollection AddPresenters(this IServiceCollection services)
    {
        services.AddScoped<IAddVideoOutputPort, VideoPresenter>();
        return services;
    }
}