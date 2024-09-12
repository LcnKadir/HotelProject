using AutoMapper;
using HotelProject.EntityLayer.Concrete;
using HotelProject.WebApi.Dtos.ServiceDto;
using HotelProject.WebUI.Dtos.RegisterDto;

namespace HotelProject.WebUI.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<ResultServiceDto, Service>().ReverseMap();
            CreateMap<UpdateServiceDto, Service>().ReverseMap();
            CreateMap<CreateServiceDto, Service>().ReverseMap();

            CreateMap<CreateNewUserDto, AppUser>().ReverseMap();
        }
    }
}
