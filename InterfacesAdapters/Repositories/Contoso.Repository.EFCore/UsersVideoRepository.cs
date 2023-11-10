using Contoso.Entities;
using Contoso.Entities.Abstractions.Repositories;

namespace Contoso.Repository.EFCore;

public class UsersVideoRepository : IUsersVideoRepository
{
    private readonly ContosoDBContext _context;

    public UsersVideoRepository(ContosoDBContext context)
    {
        _context = context;
    }

    public async Task<UsersVideo> Add(UsersVideo entity)
    {
        await _context.UsersVideos.AddAsync(entity);
        await _context.SaveChangesAsync();

        return entity;
    }

    public async Task<UsersVideo> Delete(UsersVideo entity)
    {
        _context.UsersVideos.Remove(entity);
        await _context.SaveChangesAsync();
        return entity;
    }
}