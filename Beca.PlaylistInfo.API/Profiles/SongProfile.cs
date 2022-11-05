using AutoMapper;

namespace Beca.PlaylistInfo.API.Profiles
{
    public class SongProfile : Profile
    {
        public SongProfile()
        {
            CreateMap<Entities.Song,Models.SongDto>();
        }
        
    }
}
