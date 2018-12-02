using System;

namespace Passenger.Core.Domain
{
    public class Passenger
    {
        public Guid UserId { get; protected set; }
        public Node Address { get; protected set; }
    }
}