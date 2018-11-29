using System;

namespace Passenger.Core.Domain
{
    public class User
    {
        public Guid Id { get; protected set; }
        public string Email { get; protected set; }
        public string Password { get; protected set; }
        public string Salt { get; protected set; }
        public string UserName { get; protected set; }
        public string FullName { get; protected set; }
        public DateTime CreatedAt { get; protected set;}

        protected User()
        {
        }

        public User (string email, string password, string salt, string username)
        {
            Id=Guid.NewGuid();
            Email=email;
            Password=password;
            Salt=salt;
            UserName=username;
            CreatedAt=DateTime.UtcNow;
        }

    }
}