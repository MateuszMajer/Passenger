using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Passenger.Core.Domain;

namespace Passenger.Core.Repositories
{
    public interface IUserRepository : IRepository
    {
        Task<User> GetAsync(string email);
        Task<User> GetAsync(Guid ID);
        Task AddAsync(User user);
        Task RemoveAsync(User user);  // Guid ID
        Task UpdateAsync(User user);
        Task<IEnumerable<User>> GetAllAsync();
    }
}