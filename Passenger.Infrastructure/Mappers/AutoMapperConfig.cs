using AutoMapper;
using Passenger.Core.Domain;
using Passenger.Infrastructure.DTO;

namespace Passenger.Infrastructure.Mappers
{
    public static class AutoMapperConfig
    {
        public static IMapper Initialize()
        => new MapperConfiguration(config =>
        {
            config.CreateMap<User, UserDTO>();
            config.CreateMap<Driver, DriverDTO>();
        }).CreateMapper();
    }
}