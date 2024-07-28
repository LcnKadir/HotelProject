using AutoMapper;
using HotelProject.DtoLayer.Dtos.RoomDto;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.WebApi.Mapping
{
    public class AutoMapperConfig: Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<RoomAddDto, Room>();
            CreateMap<Room, RoomAddDto>();

            CreateMap<UpdateRoomDto, Room>().ReverseMap(); // //Thanks to "ReverseMap", the problem of writing the operation twice is eliminated and reverse maple also performs it.//"ReverseMap" sayesinde işlemi iki kere yazma sıkıntısı ortadan kalkar ve tersine mapleme de yapar.
        }
    }
}
