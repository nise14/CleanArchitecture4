namespace Contoso.Entities.Abstractions.Repositories;

public interface IVideoRepository : IBaseRepository<Video>
{
    Task<List<Video>> GetAll();
}