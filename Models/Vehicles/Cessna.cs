using System;

namespace garysCarSale
{
    public class Cessna : Vehicle, IGasPowered
    {  // Propellor light aircraft
        public string VehicleName {get; set; }
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            Console.WriteLine("ReFueling...");
        }
        public override void Drive()
        {
            Console.WriteLine($"The silver cessna flys overhead. Brrrrrrrrrrr");
        }
    }
}