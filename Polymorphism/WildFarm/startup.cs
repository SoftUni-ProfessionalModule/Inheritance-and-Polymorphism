using System;

namespace WildFarm
{
    public class Startup
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();

            while (inputLine != "End")
            {
                var animalInfo = inputLine.Split();
                var foodInfo = Console.ReadLine().Split();
                var foodQuantity = int.Parse(foodInfo[1]);
                Food foodType;

                if (foodInfo[0] == "Vegetable")
                {
                    foodType = new Vegetable(foodQuantity);
                }
                else
                {
                    foodType = new Meat(foodQuantity);
                }

                switch (animalInfo[0])
                {
                    case "Mouse":
                        Mammal mouse = new Mouse(animalInfo[0], animalInfo[1], double.Parse(animalInfo[2]), animalInfo[3]);
                        mouse.MakeSound();
                        mouse.Eat(foodType);
                        Console.WriteLine(mouse);
                        break;
                    case "Zebra":
                        Mammal zebra = new Zebra(animalInfo[0], animalInfo[1], double.Parse(animalInfo[2]), animalInfo[3]);
                        zebra.MakeSound();
                        zebra.Eat(foodType);
                        Console.WriteLine(zebra);
                        break;
                    case "Cat":
                        Felime cat = new Cat(animalInfo[0], animalInfo[1], double.Parse(animalInfo[2]), animalInfo[3], animalInfo[4]);
                        cat.MakeSound();
                        cat.Eat(foodType);
                        Console.WriteLine(cat);
                        break;
                    case "Tiger":
                        Felime tiger = new Tiger(animalInfo[0], animalInfo[1], double.Parse(animalInfo[2]), animalInfo[3]);
                        tiger.MakeSound();
                        tiger.Eat(foodType);
                        Console.WriteLine(tiger);
                        break;
                }

                inputLine = Console.ReadLine();
            }
        }
    }
}