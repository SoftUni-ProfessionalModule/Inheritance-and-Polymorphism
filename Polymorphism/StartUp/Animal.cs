public class Animal
{
    private string name;
    private string favoriteFood;

    public Animal(string name, string favoriteFood)
    {
        this.Name = name;
        this.FavoriteFood = favoriteFood;
    }

    public string Name
    {
        get { return this.name; }
        protected set { this.name = value; }
    }

    public string FavoriteFood
    {
        get { return this.favoriteFood; }
        protected set { this.favoriteFood = value; }
    }
    public virtual string ExplainMyself()
    {
        return $"I am {this.Name} and my fovourite food is {this.FavoriteFood}";
    }
}