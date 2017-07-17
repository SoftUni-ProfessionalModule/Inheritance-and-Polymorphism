namespace AnimalsProject
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var animalType = Console.ReadLine();

            while (animalType != "Beast!")
            {
                var animalDetails = Console.ReadLine().Split();

                try
                {
                    var age = 0;

                    if (!int.TryParse(animalDetails[1], out age))
                    {
                        throw new ArgumentException("Invalid input!");
                    }

                    var currentAnimal = AnimalFactory.Get(animalType, animalDetails[0], age, animalDetails[2]);
                    Console.WriteLine(currentAnimal);
                    Console.WriteLine(currentAnimal.ProduceSound());
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                animalType = Console.ReadLine();
            }
        }
    }
}