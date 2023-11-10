using Contoso.Abstractions.Entities;

namespace Contoso.Entities;

public class Favorite : IEntity
{
    public Guid Id { get; set; }
    public int CourseId { get; set; }
    public int UserId { get; set; }
    public Course Course { get; set; } = null!;
    public User User { get; set; } = null!;
}