using System;
using System.Collections.Generic;

namespace Passenger.Core.Domain
{
    public class Driver //Agregate - korzeń łączący valueobject np.Node
    {
        public Guid UserID { get; protected set; }
        public Vehicle Vehicle  { get; protected set; }
        public IEnumerable<Route> Routes { get; protected set; }
        public IEnumerable<DailyRoute> DailyRoutes { get; protected set; }

        public Driver()
        {
        }
    }
}