using Beca.PlaylistInfo.API.Entities;
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;

namespace Beca.PlaylistInfo.API.Repositories
{
    public class PlaylistRepository : IPlaylistRepository
    {
        private readonly PlaylistInfoContext context;

        public PlaylistRepository(PlaylistInfoContext context)
        {
            context = context ?? throw new ArgumentNullException(nameof(context));
        }

        async Task<IEnumerable<Playlist>> IPlaylistRepository.GetPlaylistsAsync()  //TO RESEARCH LATER
        {
            return await context.Playlists.OrderBy(c => c.Title).ToListAsync();
        }
    }
}
