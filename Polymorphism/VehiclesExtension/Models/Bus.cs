namespace VehiclesExtension
{
    public class Bus : Vehicle
    {
        private const double AcConsumption = 1.4;

        public Bus(double fuealQuantity, double fuelConsumptionPerKm, double tankCapacity)
            : base(fuealQuantity, fuelConsumptionPerKm, tankCapacity)
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
