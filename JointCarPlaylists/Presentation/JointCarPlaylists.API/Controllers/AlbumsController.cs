using JointCarPlaylists.Application.Abstractions.ServicesAbstract;
using JointCarPlaylists.Infrastructure.Services.ServicesConcrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JointCarPlaylists.API.Controllers
{
    [Route("api/albums")]
    [ApiController]
    public class AlbumsController : ControllerBase
    {
        private readonly IServiceManager _service;

        public AlbumsController(IServiceManager service) => _service = service;

        [HttpGet]
        public IActionResult GetAlbums()
        {
            try
            {
                var albums = _service.AlbumService.GetAllAlbums(trackChanges: false);

                return Ok(albums);
            }
            catch
            {
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
