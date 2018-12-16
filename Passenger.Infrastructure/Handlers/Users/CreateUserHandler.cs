using System.Threading.Tasks;
using Passenger.Infrastructure.Commands;
using Passenger.Infrastructure.Commands.User;
using Passenger.Infrastructure.Services;

namespace Passenger.Infrastructure.Handlers.Users
{
    public class CreateUserHandler : ICommandHandler<CreateUser>
    {
        private readonly IUserService _iuserservice;
  
        public CreateUserHandler(IUserService iuserservice)
        {
            _iuserservice = iuserservice;
        }

        public async Task HandleAsync(CreateUser command)
        {
            await _iuserservice.RegisterAsync(command.Email,command.UserName,command.Password);
        }
    }
}