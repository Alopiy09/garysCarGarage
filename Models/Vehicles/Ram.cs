using System;

namespace garysCarSale
{
    public class Ram : Vehicle, IGasPowered
    {  // Gas powered truck
        public string VehicleName {get; set; }
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            Console.WriteLine("ReFueling...");
        }
        public override void Drive()
        {
            Console.WriteLine($"The green ram stalls. kerplunk");
        }
    }
}