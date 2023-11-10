using Contoso.Abstractions.Entities;

namespace Contoso.Entities;

public class Course : IEntity
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    public DateTime Release { get; set; }
    public List<Favorite> Favorites { get; set; } = new();
}