using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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
            _iuserservice=iuserservice;
        }
        // GET api/values/5
        [HttpGet("{email}")]
        public UserDTO Get(string email)
        {
            return _iuserservice.Get(email);
        }

    }
}
