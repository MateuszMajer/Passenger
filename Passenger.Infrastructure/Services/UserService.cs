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
        private readonly IUserRepository _iuserrepository;
        private readonly IMapper _imapper;
        private readonly IEncrypter _iencrypter;
        public UserService(IUserRepository userRepository, IEncrypter encrypter, IMapper mapper)
        {
            _iuserrepository = userRepository;
            _imapper = mapper;
            _iencrypter = encrypter;
        }

        public async Task<UserDTO> GetAsync(string email)
        {
            var user = await _iuserrepository.GetAsync(email);
            return _imapper.Map<User, UserDTO>(user);
        }

        public async Task RegisterAsync(string email, string username, string password)
        {
            var NewUser = await _iuserrepository.GetAsync(email);
            if (NewUser != null)
            {
                throw new Exception($"User with {email} already exists !");
            }
            var salt = Guid.NewGuid().ToString();
            var User = new User(email, password, salt, username);
            await _iuserrepository.AddAsync(User);
        }
    }
}