using System;

namespace garysCarSale
{
    public class Zero : Vehicle, IElectricPowered
    {  // Electric motorcycle

        public string VehicleName {get; set; }
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            Console.WriteLine("Charging...");
        }

        public override void Drive() {
            Console.WriteLine("The red zero");
        }
    }
}