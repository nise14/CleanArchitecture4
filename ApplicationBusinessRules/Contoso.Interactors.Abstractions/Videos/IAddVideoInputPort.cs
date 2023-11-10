using Contoso.Interactors.Abstractions.DTO;

namespace Contoso.Interactors.Abstractions.Videos;

public interface IAddVideoInputPort
{
    Task Handle(VideoDTO add);
}