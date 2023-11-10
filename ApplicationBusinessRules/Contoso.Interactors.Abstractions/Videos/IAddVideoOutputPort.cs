using Contoso.Interactors.Abstractions.DTO;

namespace Contoso.Interactors.Abstractions.Videos;

public interface IAddVideoOutputPort
{
    VideoDTO Content { get; }
    Task Handle(VideoDTO add);
}