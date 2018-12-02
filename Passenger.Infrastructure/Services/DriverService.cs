using System;
using AutoMapper;
using Passenger.Infrastructure.DTO;

namespace Passenger.Infrastructure.Services
{
    public class DriverService : IDriverService
    {
        private readonly IDriverService _idriverservice;
        private readonly IMapper _imapper;

        public DriverService(IDriverService idriverservice, IMapper imapper)
        {
            _idriverservice = idriverservice;
            _imapper=imapper;
        }

        public DriverDTO Get(Guid UserID)
        {
            var driver = _idriverservice.Get(UserID);
            return _imapper.Map<DriverDTO,DriverDTO>(driver);
        }
    }
}