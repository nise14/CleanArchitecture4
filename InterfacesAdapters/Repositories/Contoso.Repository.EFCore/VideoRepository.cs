using Contoso.Entities;
using Contoso.Entities.Abstractions.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Contoso.Repository.EFCore;

public class VideoRepository : IVideoRepository
{
    private readonly ContosoDBContext _context;

    public VideoRepository(ContosoDBContext context)
    {
        _context = context;
    }

    public async Task<Video> Add(Video video)
    {
        await _context.Videos.AddAsync(video);
        await _context.SaveChangesAsync();

        return video;
    }

    public async Task<Video> Delete(Video video)
    {
        _context.Remove(video);
        await _context.SaveChangesAsync();
        return video;
    }

    public async Task<List<Video>> GetAll()
    {
        return await _context.Videos.ToListAsync();
    }
}