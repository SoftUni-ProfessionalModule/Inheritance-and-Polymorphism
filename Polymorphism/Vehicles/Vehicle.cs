using System;

namespace Vehicles
{
    public abstract class Vehicle
    {
        private double fuelQuantity;
        private double consumptionPerLiter;
        
        public Vehicle(double fuelQuantity, double consumptionPerLiter, double fuelTankCapacity)
        {
            this.FuelQuantity = fuelQuantity;
            this.ConsumptionPerLiter = consumptionPerLiter;
            this.FuelTankCapacity = fuelTankCapacity;
        }

        public double FuelTankCapacity { get; protected set; }

        public virtual double FuelQuantity
        {
            get { return this.fuelQuantity; }
            protected set { this.fuelQuantity = value; }
        }

        public virtual double ConsumptionPerLiter
        {
            get { return this.consumptionPerLiter; }
            protected set { this.consumptionPerLiter = value; }
        }

        public abstract void Driving(double distance);

        public virtual void Refueling(double liters)
        {
            if (liters <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            if (liters + this.FuelQuantity > this.FuelTankCapacity)
            {
                throw new ArgumentException("Cannot fit fuel in tank");
            }

            this.FuelQuantity += liters;
        }
    }
}