using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Passenger.Infrastructure.Commands;
using Passenger.Infrastructure.Commands.User;
using Passenger.Infrastructure.DTO;
using Passenger.Infrastructure.Services;
using Passenger.Infrastructure.Settings;

namespace Passenger.Api.Controllers
{
    public class UserController : ApiControllerBase
    {
        private readonly IUserService _iuserservice;
        public UserController(IUserService iuserservice, ICommandDispatcher commandDispatcher, GeneralSettings settings) : base(commandDispatcher)
        {
            _iuserservice = iuserservice;
        }

        [HttpGet("{email}")]
        public async Task<IActionResult> Get(string email)
        {
            var user = await _iuserservice.GetAsync(email);
            if (user == null)
            {
                return NotFound("Nie znaleziono użytkownika o podanym adresie a-mail!");
            }
            return Json(user);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]CreateUser command)
        {
            await Commanddispatcher.DispatchAsync(command);
            return Created($"user/{command.Email}", "");
        }
    }
}
