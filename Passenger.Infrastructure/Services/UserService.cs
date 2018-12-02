using System;
using AutoMapper;
using Passenger.Core.Domain;
using Passenger.Core.Repositories;
using Passenger.Infrastructure.DTO;

namespace Passenger.Infrastructure.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _iuserrepository;
        private readonly IMapper _imapper;
        public UserService(IUserRepository userRepository, IMapper imapper)
        {
            _iuserrepository = userRepository;
            _imapper = imapper;
        }

        public UserDTO Get(string email)
        {
            var user = _iuserrepository.Get(email);
            return _imapper.Map<User, UserDTO>(user);
        }

        public void Register(string email, string username, string password)
        {
            var NewUser = _iuserrepository.Get(email);
            if (NewUser != null)
            {
                throw new Exception($"User with {email} already exists !");
            }
            var salt = Guid.NewGuid().ToString();
            var User = new User(email, password, salt, username);
            _iuserrepository.Add(User);
        }
    }
}