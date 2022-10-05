using AutoMapper;
using platformservice.Model;

namespace platformservice.Dtos
{

    public class PlatformProfile : Profile
    {
        public PlatformProfile()
        {
            CreateMap<Platform, PlatformReadData>();
            CreateMap<PlatformCreateData, Platform>();

        }
    }
}