using System;

namespace Passenger.Infrastructure.Commands.Driver
{
    public class CreateDriver : ICommand
    {
        public Guid UserID { get; set; }
        public DriverVehicle Vehicle { get; set; }
    }

    public class DriverVehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Seats { get; set; }
    }
}