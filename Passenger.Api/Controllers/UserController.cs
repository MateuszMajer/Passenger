using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Passenger.Infrastructure.Commands.User;
using Passenger.Infrastructure.DTO;
using Passenger.Infrastructure.Services;

namespace Passenger.Api.Controllers
{
    [Route("[controller]")]
    public class UserController : Controller
    {
        private readonly IUserService _iuserservice;
        public UserController(IUserService iuserservice)
        {
            _iuserservice = iuserservice;
        }


        [HttpGet("{email}")]
        public Task<UserDTO> Get(string email)
        {
            return _iuserservice.GetAsync(email);
        }

        [HttpPost]
        public async Task Post([FromBody]CreateUser request)
        {
           await _iuserservice.RegisterAsync(request.Email, request.UserName, request.Password);
        }

    }
}
