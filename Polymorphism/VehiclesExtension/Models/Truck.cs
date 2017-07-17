namespace VehiclesExtension
{
    public class Truck : Vehicle
    {
        private const double acConsumption = 1.6;
        private const double fuelLossFactor = 0.95;

        public Truck(double fuealQuantity, double fuelConsumptionPerKm, double tankCapacity) 
            : base(fuealQuantity, fuelConsumptionPerKm + acConsumption, tankCapacity)
        {
        }

        public override void Refuel(double fuelAmount)
        {
            base.Refuel(fuelAmount * fuelLossFactor);
        }
    }
}
