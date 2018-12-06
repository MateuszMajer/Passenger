using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Passenger.Core.Domain;

namespace Passenger.Core.Repositories
{
    public interface IDriverRepository
    {
        Task<Driver> GetAsync(Guid UserID);
        Task AddAsync(Driver driver);
        Task UpdateAsync(Driver driver);
        Task<IEnumerable<Driver>> GetAllAsync();
    }
}