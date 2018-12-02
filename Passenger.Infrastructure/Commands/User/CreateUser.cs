namespace Passenger.Infrastructure.Commands.User
{
    public class CreateUser:ICommand
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
    }
}