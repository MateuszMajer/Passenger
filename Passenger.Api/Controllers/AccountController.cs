using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Passenger.Infrastructure.Commands;
using Passenger.Infrastructure.Commands.User;
using Passenger.Infrastructure.Services;

namespace Passenger.Api.Controllers
{
    public class AccountController : ApiControllerBase
    {
        private readonly IJwtHandler _jwthandler;
        public AccountController(ICommandDispatcher commandDispatcher, IJwtHandler jwtHandler) : base(commandDispatcher)
        {
            _jwthandler = jwtHandler;
        }

        [HttpPut]
        [Route("password")]
        public async Task<IActionResult> Put([FromBody]ChangeUserPassword command)
        {
            await Commanddispatcher.DispatchAsync(command);
            return NoContent();
        }

        [HttpGet]
        [Route("token")]
        public IActionResult Get()
        {
            var token = _jwthandler.CreateToken("user1@gmail.com", "user");
            return Json(token);
        }
    }
}