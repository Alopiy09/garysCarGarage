

using System;
using System.Collections.Generic;

namespace garysCarSale
{
    public class batteryStation : Vehicle, IStations<IElectricPowered>
    {
        public int capacity { get; set; }

        
        public void Refuel (IElectricPowered electricCar)
        {
            Console.WriteLine($"The {electricCar.VehicleName} has been charged to {electricCar.BatteryKWh} KWH");
        }
    }
}