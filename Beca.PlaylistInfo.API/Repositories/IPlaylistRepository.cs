using Beca.PlaylistInfo.API.Entities;

namespace Beca.PlaylistInfo.API.Repositories
{
    public interface IPlaylistRepository
    {
        Task<IEnumerable<Playlist>> GetPlaylistsAsync();
    }
}
