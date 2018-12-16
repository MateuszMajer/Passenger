using Microsoft.AspNetCore.Mvc;
using Passenger.Infrastructure.Commands;
using Passenger.Infrastructure.Services;

namespace Passenger.Api.Controllers
{
    [Route("[controller]")]
    public abstract class ApiControllerBase : Controller
    {
        protected readonly ICommandDispatcher Commanddispatcher;
        protected ApiControllerBase(ICommandDispatcher commanddispatcher)
        {
            Commanddispatcher = commanddispatcher;
        }
    }
}