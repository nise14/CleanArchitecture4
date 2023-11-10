using Contoso.Entities.Abstractions.Repositories.Queries;
using Microsoft.Extensions.DependencyInjection;

namespace Contoso.Repository.Dapper;

public static class DependencyContainer
{
    public static IServiceCollection AddDapperRepository(this IServiceCollection services)
    {
        services.AddScoped<Connection>();
        services.AddScoped<IQueryVideoRepository, QueryVideoRepository>();  
        return services;
    }
}