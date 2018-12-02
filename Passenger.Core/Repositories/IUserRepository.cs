using System;
using Passenger.Core.Domain;

namespace Passenger.Core.Repositories
{
    public interface IUserRepository
    { // Try use ID :)
         User Get(string email);
         User Get(Guid ID);
         void Add(User user);
         void Remove(User user); 
         void Update(User user);
    }
}