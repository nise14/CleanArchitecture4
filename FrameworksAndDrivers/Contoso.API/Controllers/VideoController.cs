using System.Reflection.Metadata.Ecma335;
using Contoso.Interactors.Abstractions.DTO;
using Contoso.Interactors.Abstractions.Videos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace Contoso.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class VideoController : ControllerBase
{
    private readonly IAddVideoInputPort _inputPort;
    private readonly IAddVideoOutputPort _outputPort;

    public VideoController(IAddVideoInputPort inputPort,
        IAddVideoOutputPort outputPort)
    {
        _inputPort = inputPort;
        _outputPort = outputPort;
    }

    [HttpPost]
    public async Task<IActionResult> AddVideo(VideoDTO add)
    {
        await _inputPort.Handle(add);
        var response = _outputPort.Content;
        return Ok(response);
    }
}