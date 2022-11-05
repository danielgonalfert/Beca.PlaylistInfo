using AutoMapper;


namespace Beca.PlaylistInfo.API.Profiles
{
    public class PlaylistProfile : Profile
    {
        public PlaylistProfile()
        {
            CreateMap<Entities.Playlist, Models.PlaylistDto>();
        }
    }
}
