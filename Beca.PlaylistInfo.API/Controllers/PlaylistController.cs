using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using Beca.PlaylistInfo.API.Models;
using Beca.PlaylistInfo.API.Repositories;
using Beca.PlaylistInfo.API.Entities;

namespace Beca.PlaylistInfo.API.Controllers
{
    [ApiController]
    [Route("api/playlists")]
    public class PlaylistController : ControllerBase
    {
        private readonly IPlaylistRepository playlistRepository;
        private readonly IMapper mapper;
        
       
        public PlaylistController(IPlaylistRepository playlistRepository, IMapper mapper)
        {
            this.playlistRepository = playlistRepository;
            this.mapper = mapper;

        }

        [HttpGet()]

        public async Task<ActionResult<IEnumerable<PlaylistDto>>> GetPlaylists()
        {
            IEnumerable<Playlist> playlistEntities = await playlistRepository.GetPlaylistsAsync();
            return Ok(mapper.Map<IEnumerable<PlaylistDto>>(playlistEntities));
        }
        

    };
}