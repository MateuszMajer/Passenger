using System;
using System.Threading.Tasks;
using AutoMapper;
using Passenger.Core.Domain;
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

        public DriverDTO GetAsync(Guid UserID)
        {
            var driver =  _idriverservice.GetAsync(UserID);
            return driver;
        }
    }
}