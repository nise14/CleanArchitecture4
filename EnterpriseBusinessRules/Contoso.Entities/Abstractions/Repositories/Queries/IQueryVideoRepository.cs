namespace Contoso.Entities.Abstractions.Repositories.Queries;

public interface IQueryVideoRepository
{
    Task<List<Video>> GetAllVideosByTitle(string title);
}