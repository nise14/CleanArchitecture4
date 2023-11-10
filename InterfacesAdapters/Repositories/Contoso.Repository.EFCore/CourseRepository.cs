using Contoso.Entities;
using Contoso.Entities.Abstractions.Repositories;

namespace Contoso.Repository.EFCore;

public class CourseRepository : ICourseRepository
{
    private readonly ContosoDBContext _context;

    public CourseRepository(ContosoDBContext context)
    {
        _context = context;
    }

    public async Task<Course> Add(Course course)
    {
        await _context.Courses.AddAsync(course);

        await _context.SaveChangesAsync();

        return course;
    }

    public async Task<Course> Delete(Course course)
    {
        _context.Courses.Remove(course);
        await _context.SaveChangesAsync();
        return course;
    }
}