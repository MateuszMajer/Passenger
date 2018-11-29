using System;
using Passenger.Core.Domain;

namespace Passenger.Core.Repositories
{
    public interface IUserRepository
    {
         User Get(string email);
         User Get(Guid ID);
         void Add(User user);
         void Remove(User user);  // Guid ID
         void Update(User user);
    }
}