namespace Passenger.Infrastructure.DTO
{
    public class JwtDTO
    {
        public string Token { get; set; }
        public long Expiry { get; set; }
    }
}