namespace WildFarm
{
    public abstract class Animal
    {
        public Animal(string type, string name, double weight)
        {
            this.AnymalType = type;
            this.AnimalName = name;
            this.AnimalWeight = weight;
        }

        public string AnymalType{ get;}

        public string AnimalName{ get;}

        public double AnimalWeight { get;}

        public int FoodEaten { get; set; }

        public abstract void MakeSound();

        public abstract void Eat(Food food);
    }
}