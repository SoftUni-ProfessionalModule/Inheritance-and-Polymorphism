namespace WildFarm
{
    using System;

    public class Zebra : Mammal
    {
        public Zebra(string type, string name, double weight, string region) 
            : base(type, name, weight, region)
        {
        }

        public override void Eat(Food food)
        {
            if (food is Meat)
            {
                Console.WriteLine("Zebras are not eating that type of food!");
            }
            else
            {
                FoodEaten = food.Quantity;
            }
        }

        public override void MakeSound()
        {
            Console.WriteLine("Zs");
        }
    }
}