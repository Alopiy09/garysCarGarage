using System;

namespace garysCarSale
{
    public class Tesla : Vehicle, IElectricPowered
    {  // Electric car
        public string VehicleName {get; set; }
        public double BatteryKWh { get; set; }
        public void ChargeBattery()
        {
            Console.WriteLine("Charging...");
        }
        public override void Drive()
        {
            Console.WriteLine($"The black tesla teleports. Beam me up scotty");
        }
    }
}