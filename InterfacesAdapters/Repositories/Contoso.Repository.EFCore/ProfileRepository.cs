using Contoso.Entities;
using Contoso.Entities.Abstractions.Repositories;

namespace Contoso.Repository.EFCore;

public class ProfileRepository : IProfileRepository
{
    private readonly ContosoDBContext _context;

    public ProfileRepository(ContosoDBContext context)
    {
        _context = context;
    }

    public async Task<Profile> Add(Profile entity)
    {
        await _context.Profiles.AddAsync(entity);
        await _context.SaveChangesAsync();

        return entity;
    }

    public async Task<Profile> Delete(Profile entity)
    {
        _context.Profiles.Remove(entity);
        await _context.SaveChangesAsync();
        return entity;
    }
}