using System;
using Passenger.Core.Domain;
using Passenger.Core.Repositories;
using Passenger.Infrastructure.DTO;

namespace Passenger.Infrastructure.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _iuserrepository;

        public UserService(IUserRepository userRepository)
        {
            _iuserrepository=userRepository;
        }

        public UserDTO Get(string email)
        {
            var user=_iuserrepository.Get(email);
            return new UserDTO
            {
                Id=user.Id,
                UserName=user.UserName,
                FullName=user.FullName,
                Email=user.Email
            };
        }

        public void Register(string email, string username, string password)
        {
            var NewUser=_iuserrepository.Get(email);
            if(NewUser!=null)
            {
                throw new Exception($"User with {email} already exists !");
            }
            var salt=Guid.NewGuid().ToString();
            var User=new User(email,password,salt,username);
            _iuserrepository.Add(User);
        }
    }
}