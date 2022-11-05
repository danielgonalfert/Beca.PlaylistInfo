namespace Beca.PlaylistInfo.API.Models
{
    public class SongDto
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string? Description { get; set; }

        public PlaylistDto? Playlist { get; set; }
    }
}
