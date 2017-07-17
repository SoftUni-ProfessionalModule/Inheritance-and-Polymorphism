using System;

namespace Vehicles
{
    public class Car : Vehicle
    {
        private const double summerFuelIncrease = 0.9;

        public Car(double fuelQuantity, double consumptionPerLiter, double fuelTankCapacity)
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
                throw new ArgumentException("Car needs refueling");
            }

            base.FuelQuantity -= distance * this.ConsumptionPerLiter;
        }

        public override void Refueling(double liters)
        {
            base.Refueling(liters);
        }
    }
}