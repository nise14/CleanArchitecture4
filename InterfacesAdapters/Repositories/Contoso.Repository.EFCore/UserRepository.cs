using Azure.Identity;
using Contoso.Entities;
using Contoso.Entities.Abstractions.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Contoso.Repository.EFCore;

public class UserRepository : IUsersRepository
{
    private readonly ContosoDBContext _context;

    public UserRepository(ContosoDBContext context)
    {
        _context = context;
    }

    public async Task<User> Add(User entity)
    {
        await _context.Users.AddAsync(entity);
        await _context.SaveChangesAsync();

        return entity;
    }

    public async Task<User> Delete(User entity)
    {
        _context.Users.Remove(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task<User> GetByUserName(string userName)
    {
        return await _context.Users.Where(o => o.Name == userName).FirstOrDefaultAsync() ?? new User();
    }
}