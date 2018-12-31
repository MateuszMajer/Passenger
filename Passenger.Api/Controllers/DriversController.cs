using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Passenger.Infrastructure.Commands;
using Passenger.Infrastructure.Commands.User;

namespace Passenger.Api.Controllers
{
    public class DriversController: ApiControllerBase
    {
        public DriversController(ICommandDispatcher commandDispatcher) : base(commandDispatcher)
        {
        }

        [HttpPost]
        public async Task<IActionResult> Put([FromBody]ChangeUserPassword command)
        {
            await Commanddispatcher.DispatchAsync(command);
            return NoContent();
        }     
    }
}