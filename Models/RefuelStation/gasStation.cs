using System;
using System.Collections.Generic;


namespace garysCarSale {
    public class gasStation : Vehicle, IStations<IGasPowered> 
    {
        public int capacity { get; set; }

        public void Refuel (IGasPowered gasCar)
        {
            Console.WriteLine($"The {gasCar.VehicleName} has been refueled to {gasCar.FuelCapacity} gallons");
        }
        
    }
 }