using Contoso.Abstractions.Entities;

namespace Contoso.Entities.Abstractions.Repositories;

public interface IBaseRepository<TEntity> where TEntity : IEntity
{
    Task<TEntity> Add(TEntity entity);
    Task<TEntity> Delete(TEntity entity);
}