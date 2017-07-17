namespace WildFarm
{
    public abstract class Mammal : Animal
    {
        public Mammal(string type, string name, double weight, string region) 
            : base(type, name, weight)
        {
            this.LivingRegion = region;
        }

        public string LivingRegion { get; }

        public override string ToString()
        {
            return $"{this.GetType().Name}[{this.AnimalName}, {this.AnimalWeight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}