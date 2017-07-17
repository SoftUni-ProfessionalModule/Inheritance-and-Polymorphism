using System;

namespace VehiclesExtension
{
    public abstract class Vehicle
    {
        public Vehicle(double fuealQuantity, double fuelConsumptionPerKm, double tankCapacity)
        {
            this.FuelQuantity = fuealQuantity;
            this.FuelConsumptionPerKm = fuelConsumptionPerKm;
            this.TankCapacity = tankCapacity;
        }
         
        protected virtual double FuelQuantity { get; set; }

        private double FuelConsumptionPerKm { get; set; }

        protected virtual double TankCapacity { get; set; }

        private bool Drive(double distance)
        {
            var fuelRequired = distance * this.FuelConsumptionPerKm;

            if (fuelRequired <= this.FuelQuantity)
            {
                this.FuelQuantity -= fuelRequired;
                return true;
            }

            return false;
        }

        public string TryTravelDistance(double distance, bool isAcOn)
        {
            if (this.Drive(distance))
            {
                return $"{this.GetType().Name} travelled {distance} km";
            }

            return $"{this.GetType().Name} needs refueling";
        }

        public string TryTravelDistance(double distance)
        {
            return this.TryTravelDistance(distance, true);
        }

        public virtual void Refuel(double fuelAmount)
        {
            if (fuelAmount <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }

            this.FuelQuantity += fuelAmount;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
        }
    }
}
