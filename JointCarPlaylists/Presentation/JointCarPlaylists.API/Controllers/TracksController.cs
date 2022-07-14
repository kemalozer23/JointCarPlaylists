using JointCarPlaylists.Application.Abstractions.ServicesAbstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JointCarPlaylists.API.Controllers
{
    [Route("api/tracks")]
    [ApiController]
    public class TracksController : ControllerBase
    {
        private readonly IServiceManager _service;

        public TracksController(IServiceManager service) => _service = service;

        [HttpGet]
        public IActionResult GetArtists()
        {
            try
            {
                var tracks = _service.TrackService.GetAllTracks(trackChanges: false);

                return Ok(tracks);
            }
            catch
            {
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
