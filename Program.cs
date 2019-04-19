using System;
using System.Collections.Generic;

namespace garysCarSale
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Create some electric vehicles, add them to a List
                and then iterate the List to charge all of their
                batteries.
            */
            Zero fxs = new Zero()
            {
                VehicleName = "FXS",
                MainColor = "White",
                MaximumOccupancy = 1,
                BatteryKWh = 230.3,

            };

            Tesla modelS = new Tesla()
            {   
                VehicleName = "Tesla model S",
                MainColor = "Black",
                MaximumOccupancy = 4,
                BatteryKWh = 600.32,
                
            };

            List<IElectricPowered> electricVehicles = new List<IElectricPowered>() {
                 fxs, modelS
            };

            // electricVehicles.ForEach(gv => gv.ChargeBattery());

            /*
                Create some gas vehicles, add them to a List
                and then iterate the List to fill all of their
                fuel tanks.
            */
            Ram ram = new Ram()
            {
                VehicleName = "Ram",
                MainColor = "Green",
                MaximumOccupancy = 5,
                FuelCapacity = 23.3,
                
            };
            Cessna cessna150 = new Cessna()
            {
                VehicleName = "Cessna 150",
                MainColor = "Silver",
                MaximumOccupancy = 6,
                FuelCapacity = 432.4,
            };

            List<IGasPowered> gasVehicles = new List<IGasPowered>() {
                ram, cessna150
            };

            // gasVehicles.ForEach(gv => gv.RefuelTank());
            cessna150.Drive();

            gasStation Mrpizza = new gasStation();


            gasVehicles.ForEach(gv => Mrpizza.Refuel(gv));

            batteryStation Hyperion = new batteryStation();

            electricVehicles.ForEach(ev => Hyperion.Refuel(ev));


            


        }
    }
}