using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Passenger.Core.Domain;
using Passenger.Core.Repositories;

namespace Passenger.Infrastructure.Repositories
{
    public class InMemoryUserRepository : IUserRepository
    {
        private static ISet<User> _users = new HashSet<User>{
            new User("user1@gmail.com","secretpassword","salt","mateusz"),
            new User("user2@gmail.com","secretpassword","salt","twoja stara"),
            new User("user3@gmail.com","secretpassword","salt","twoj stary")
        };

        public async Task AddAsync(User user) => await Task.FromResult(_users.Add(user));

        public async Task<User> GetAsync(string email) => await Task.FromResult(_users.SingleOrDefault(user => user.Email == email.ToLowerInvariant()));

        public async Task<User> GetAsync(Guid ID) => await Task.FromResult(_users.SingleOrDefault(user => user.Id == ID));

        public async Task<IEnumerable<User>> GetAllAsync() => await Task.FromResult(_users);

        public async Task RemoveAsync(User user) => await Task.FromResult(_users.Remove(user));

        public async Task UpdateAsync(User user) => await Task.CompletedTask;

    }
}