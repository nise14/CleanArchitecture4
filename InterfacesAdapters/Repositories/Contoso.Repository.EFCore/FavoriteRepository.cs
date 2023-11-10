using Contoso.Entities;
using Contoso.Entities.Abstractions.Repositories;

namespace Contoso.Repository.EFCore;

public class FavoriteRepository : IFavoriteRepository
{
    private readonly ContosoDBContext _context;

    public FavoriteRepository(ContosoDBContext context)
    {
        _context = context;
    }

    public async Task<Favorite> Add(Favorite entity)
    {
        await _context.Favorites.AddAsync(entity);
        await _context.SaveChangesAsync();

        return entity;
    }

    public async Task<Favorite> Delete(Favorite entity)
    {
        _context.Favorites.Remove(entity);
        await _context.SaveChangesAsync();
        return entity;
    }
}