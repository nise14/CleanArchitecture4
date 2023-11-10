using Contoso.Entities.Abstractions.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Contoso.Repository.EFCore;

public static class DependencyContainer
{
    public static IServiceCollection AddEFCoreRepository(this IServiceCollection services, IConfiguration config)
    {
        services.AddDbContext<ContosoDBContext>(options =>
        {
            options.UseSqlServer(config["Connection"], op =>
            {
                op.EnableRetryOnFailure(maxRetryCount: 5, maxRetryDelay: TimeSpan.FromSeconds(60), null);
            });
        });

        services.AddScoped<IVideoRepository, VideoRepository>();
        services.AddScoped<IUsersRepository, UserRepository>();
        services.AddScoped<IUsersVideoRepository, UsersVideoRepository>();
        services.AddScoped<IProfileRepository, ProfileRepository>();
        services.AddScoped<IFavoriteRepository, FavoriteRepository>();
        services.AddScoped<ICourseRepository, CourseRepository>();

        return services;
    }
}