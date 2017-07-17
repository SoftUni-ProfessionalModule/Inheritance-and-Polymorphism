namespace WildFarm
{
    using System;

    public class Cat : Felime
    {
        public Cat(string type, string name, double weight, string region, string breed) 
            : base(type, name, weight, region)
        {
            this.Breed = breed;
        }

        public string Breed { get; set; }

        public override void Eat(Food food)
        {
            FoodEaten = food.Quantity;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Meowwww");
        }

        public override string ToString()
        {
            return $"{base.AnymalType}[{base.AnimalName}, {this.Breed}, {base.AnimalWeight}, {base.LivingRegion}, {base.FoodEaten}]";
        }
    }
}