using System;
using Passenger.Infrastructure.DTO;

namespace Passenger.Infrastructure.Services
{
    public class DriverService : IDriverService
    {
        private readonly IDriverService _idriverservice;

        public DriverService(IDriverService idriverservice)
        {
            _idriverservice = idriverservice;
        }

        public DriverDTO Get(Guid UserID)
        {
            var driver = _idriverservice.Get(UserID);
            return new DriverDTO
            {
                UserId = driver.UserId,
                Vehicle = driver.Vehicle,
                Routes = driver.Routes,
                DailyRoutes = driver.DailyRoutes
            };
        }
    }
}