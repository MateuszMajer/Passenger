using System;
using System.Threading.Tasks;
using AutoMapper;
using Passenger.Core.Domain;
using Passenger.Core.Repositories;
using Passenger.Infrastructure.DTO;

namespace Passenger.Infrastructure.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userrepository;
        private readonly IMapper _mapper;
        private readonly IEncrypter _encrypter;
        public UserService(IUserRepository userRepository, IEncrypter encrypter, IMapper mapper)
        {
            _userrepository = userRepository;
            _mapper = mapper;
            _encrypter = encrypter;
        }

        public async Task<UserDTO> GetAsync(string email)
        {
            var user = await _userrepository.GetAsync(email);
            return _mapper.Map<User, UserDTO>(user);
        }

        public async Task LoginAsync(string email, string password)
        {
            var LoginUser = await _userrepository.GetAsync(email);
            if (LoginUser == null)
            {
                throw new Exception($"User with {email} doesn't exists");
            }
            var salt = _encrypter.GetSalt(password);
            var hash = _encrypter.GetHash(password, salt);
            if (hash != LoginUser.Password)
            {
                throw new Exception("Invalid password to this account");
            }
            return;
        }

        public async Task RegisterAsync(string email, string username, string password)
        {
            var NewUser = await _userrepository.GetAsync(email);
            if (NewUser != null)
            {
                throw new Exception($"User with {email} already exists !");
            }
            var salt = _encrypter.GetSalt(password);
            var hash = _encrypter.GetHash(password, salt);
            var User = new User(email, hash, salt, username);
            await _userrepository.AddAsync(User);
        }
    }
}