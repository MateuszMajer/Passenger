using System.Threading.Tasks;
using Passenger.Infrastructure.Commands;
using Passenger.Infrastructure.Commands.Driver;
using Passenger.Infrastructure.Services;

namespace Passenger.Infrastructure.Handlers.Drivers
{
    public class CreateDriverHandler : ICommandHandler<CreateDriver>
    {
        private readonly IDriverService _driverservice;
        public CreateDriverHandler(IDriverService driverservice)
        {
            _driverservice = driverservice;
        }
        public Task HandleAsync(CreateDriver command)
        {
            throw new System.NotImplementedException();
        }
    }
}