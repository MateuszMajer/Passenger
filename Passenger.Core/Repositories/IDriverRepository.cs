using System;
using System.Collections.Generic;
using Passenger.Core.Domain;

namespace Passenger.Core.Repositories
{
    public interface IDriverRepository
    {
         Driver Get(Guid UserID);
         void Add(Driver driver);
         void Update(Driver driver);
         IEnumerable<Driver> GetAll();
    }
}