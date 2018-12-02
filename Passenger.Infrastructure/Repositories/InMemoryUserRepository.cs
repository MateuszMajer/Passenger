using System;
using System.Collections.Generic;
using System.Linq;
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

        public void Add(User user) => _users.Add(user);

        public User Get(string email) => _users.Single(user => user.Email == email.ToLowerInvariant());

        public User Get(Guid ID) => _users.Single(user => user.Id == ID);

        public IEnumerable<User> GetAll() => _users;

        public void Remove(User user) => _users.Remove(user);

        public void Update(User user)
        {
        }
    }
}