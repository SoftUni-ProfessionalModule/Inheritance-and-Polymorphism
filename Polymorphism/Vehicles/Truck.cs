using System;

namespace Vehicles
{
    public class Truck : Vehicle
    {
        private const double summerFuelIncrease = 1.6;

        public Truck(double fuelQuantity, double consumptionPerLiter, double fuelTankCapacity)
            : base(fuelQuantity, consumptionPerLiter, fuelTankCapacity)
        {
        }

        public override double ConsumptionPerLiter
        {
            get { return base.ConsumptionPerLiter + summerFuelIncrease; }
        }

        public override void Driving(double distance)
        {
            if (distance * this.ConsumptionPerLiter > base.FuelQuantity)
            {
                throw new ArgumentException("Truck needs refueling");
            }

            base.FuelQuantity -= distance * this.ConsumptionPerLiter;
        }

        public override void Refueling(double liters)
        {
            if (liters <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }

            base.FuelQuantity += liters - (0.05 * liters);
        }
    }
}