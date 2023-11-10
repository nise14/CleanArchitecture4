namespace Contoso.Interactors.Abstractions.DTO;

public class VideoDTO
{
    public Guid Id { get; set; }
    public string Title { get; set; } = null!;
    public string Source { get; set; } = null!;
    public string Description { get; set; } = null!;
}