namespace Contoso.Entities.Abstractions.Repositories;

public interface IUsersRepository : IBaseRepository<User>
{
    Task<User> GetByUserName(string userName);
}