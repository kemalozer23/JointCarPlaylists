using JointCarPlaylists.Application.Abstractions.ServicesAbstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JointCarPlaylists.API.Controllers
{
    [Route("api/artists")]
    [ApiController]
    public class ArtistsController : ControllerBase
    {
        private readonly IServiceManager _service;

        public ArtistsController(IServiceManager service) => _service = service;

        [HttpGet]
        public IActionResult GetArtists()
        {
            try
            {
                var artists = _service.ArtistService.GetAllArtists(trackChanges: false);

                return Ok(artists);
            }
            catch
            {
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
