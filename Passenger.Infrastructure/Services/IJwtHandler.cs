using Passenger.Infrastructure.DTO;

namespace Passenger.Infrastructure.Services
{
    public interface IJwtHandler
    {
        JwtDTO CreateToken(string email, string role);
    }
}