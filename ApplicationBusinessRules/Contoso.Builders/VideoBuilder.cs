using Contoso.Entities;
using Contoso.Interactors.Abstractions.DTO;

namespace Contoso.Builders;

public class VideoBuilder : BuilderBase<Video, VideoDTO>
{
    public override Video Convert(VideoDTO param)
    {
        return new Video
        {
            Description = param.Description,
            Id = param.Id,
            Source = param.Source,
            Title = param.Title
        };
    }

    public override VideoDTO Convert(Video param)
    {
        return new VideoDTO
        {
            Description = param.Description,
            Id = param.Id,
            Source = param.Source,
            Title = param.Title
        };
    }
}
