using System;

namespace garysCarSale
{
    public interface IGasPowered
    {
        double FuelCapacity { get; set; }
        string VehicleName {get; set; }

        void RefuelTank();
    }
}
