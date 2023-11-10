using Contoso.Builders;
using Contoso.Entities.Abstractions.Repositories;
using Contoso.Interactors.Abstractions.DTO;
using Contoso.Interactors.Abstractions.Videos;

namespace Contoso.Videos.UseCases;

public class AddVideo : IAddVideoInputPort
{
    private readonly IAddVideoOutputPort _outputPort;
    private readonly IVideoRepository _videoRepository;
    private readonly VideoBuilder _videoBuilder;

    public AddVideo(IAddVideoOutputPort outputPort,
        IVideoRepository videoRepository,
        VideoBuilder videoBuilder)
    {
        _outputPort = outputPort;
        _videoRepository = videoRepository;
        _videoBuilder = videoBuilder;
    }

    public async Task Handle(VideoDTO add)
    {
        if (add.Title.Contains("princesas"))
        {
            add.Title = $"{add.Title} Para niños";
        }

        await _videoRepository.Add(_videoBuilder.Convert(add));
        await _outputPort.Handle(add);
    }
}
