namespace Vehicles
{
    using System;

    public class Bus : Vehicle
    {
        private const double summerFuelIncrease = 1.4;
        
        public Bus(double fuelQuantity, double consumptionPerLiter, double fuelTankCapacity)
            : base(fuelQuantity, consumptionPerLiter, fuelTankCapacity)
        {
        }

        public bool isPeople { get; set; }

        public override double ConsumptionPerLiter
        {
            get
            {
                if (this.isPeople)
                {
                    return base.ConsumptionPerLiter + summerFuelIncrease;
                }
                else
                {
                    return base.ConsumptionPerLiter;

                }
            }
        }

        public override void Driving(double distance)
        {
            if (distance * this.ConsumptionPerLiter > base.FuelQuantity)
            {
                throw new ArgumentException("Bus needs refueling");
            }

            base.FuelQuantity -= distance * this.ConsumptionPerLiter;
        }

        public override void Refueling(double liters)
        {
            base.Refueling(liters);
        }
    }
}