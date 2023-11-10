using Contoso.Abstractions.Entities;

namespace Contoso.Entities;

public class Video : IEntity
{
    public Guid Id { get; set; }
    public string Title { get; set; } = null!;
    public string Source { get; set; } = null!;
    public string Description { get; set; } = null!;
    public List<UsersVideo> UsersVideos { get; set; } = new();
}