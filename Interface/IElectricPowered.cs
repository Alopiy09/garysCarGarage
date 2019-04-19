using System;

namespace garysCarSale
{
    public interface IElectricPowered
    {
        double BatteryKWh { get; set; }
        void ChargeBattery();

        string VehicleName {get; set; }
    }
}
