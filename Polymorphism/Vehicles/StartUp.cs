namespace Vehicles
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var carInfo = Console.ReadLine().Split();
            var car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]), double.Parse(carInfo[3]));

            var truckInfo = Console.ReadLine().Split();
            var truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]), double.Parse(truckInfo[3]));

            var busInfo = Console.ReadLine().Split();
            var bus = new Bus(double.Parse(busInfo[1]), double.Parse(busInfo[2]), double.Parse(busInfo[3]));
            
            var numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                var commandTokens = Console.ReadLine().Split();

                try
                {
                    if (commandTokens[0] == "Drive")
                    {
                        if (commandTokens[1] == "Car")
                        {
                            car.Driving(double.Parse(commandTokens[2]));
                            Console.WriteLine($"Car travelled {double.Parse(commandTokens[2])} km");

                        }
                        else if (commandTokens[1] == "Truck")
                        {
                            truck.Driving(double.Parse(commandTokens[2]));
                            Console.WriteLine($"Truck travelled {double.Parse(commandTokens[2])} km");
                        }
                        else
                        {
                            bus.isPeople = true;
                            bus.Driving(double.Parse(commandTokens[2]));
                            Console.WriteLine($"Bus travelled {double.Parse(commandTokens[2])} km");
                        }
                    }
                    else if(commandTokens[0] == "DriveEmpty")
                    {
                        bus.isPeople = false;
                        bus.Driving(double.Parse(commandTokens[2]));
                        Console.WriteLine($"Bus travelled {double.Parse(commandTokens[2])} km");
                    }
                    else
                    {
                        if (commandTokens[1] == "Car")
                        {
                            car.Refueling(double.Parse(commandTokens[2]));
                        }
                        else if(commandTokens[1] == "Truck")
                        {
                            truck.Refueling(double.Parse(commandTokens[2]));
                        }
                        else
                        {
                            bus.Refueling(double.Parse(commandTokens[2]));
                        }
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
            Console.WriteLine($"Bus: {bus.FuelQuantity:f2}");
        }
    }
}