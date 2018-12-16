using Passenger.Infrastructure.Commands;

namespace Passenger.Infrastructure.Commands.User
{
    public class ChangeUserPassword : ICommand
    {
        public string CurrentPassword { get; set; }
        public string NewPassword { get; set; }
        
    }
}