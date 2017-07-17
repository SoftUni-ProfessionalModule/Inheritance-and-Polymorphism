namespace WildFarm
{
    using System;

    public class Tiger : Felime
    {
        public Tiger(string type, string name, double weight, string region) 
            : base(type, name, weight, region)
        {
        }

        public override void Eat(Food food)
        {
            if (food is Vegetable)
            {
                Console.WriteLine("Tigers are not eating that type of food!");
            }
            else
            {
                FoodEaten = food.Quantity;
            }
        }

        public override void MakeSound()
        {
            Console.WriteLine("ROAAR!!!");
        }
    }
}