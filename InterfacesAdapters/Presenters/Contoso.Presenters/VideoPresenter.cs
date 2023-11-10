using Contoso.Interactors.Abstractions.DTO;
using Contoso.Interactors.Abstractions.Videos;

namespace Contoso.Presenters;

public class VideoPresenter : IAddVideoOutputPort
{
    public VideoDTO Content { get; private set; } = null!;

    public Task Handle(VideoDTO add)
    {
        add.Description = $"{add.Description} con descripcion";
        Content = add;
        return Task.CompletedTask;
    }
}
