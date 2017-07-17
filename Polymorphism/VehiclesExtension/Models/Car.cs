namespace VehiclesExtension
{
    public class Car : Vehicle
    {
        private const double acConsumption = 0.9;

        public Car(double fuealQuantity, double fuelConsumptionPerKm, double tankCapacity)
            : base(fuealQuantity, fuelConsumptionPerKm + acConsumption, tankCapacity)
        {
        }

        protected override double FuelQuantity
        {
            set
            {
                if (value > this.TankCapacity)
                {
                    throw new ArgumentExeption("Cannot fit fuel in tank");
                }

                base.FuelQuantity = value;
            }

        }
    }
}