using Contoso.Abstractions.Entities;

namespace Contoso.Entities;

public class Profile : IEntity
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    public int UserId { get; set; }
    public User User { get; set; } = null!;
}