using System;

public class Dog : Animal
{
    public Dog(string name, string favoriteFood)
        : base(name, favoriteFood)
    {
    }

    public string Enviroment { get; private set; }

    public override string ExplainMyself()
    {
        return base.ExplainMyself() + Environment.NewLine + "DJAAF";
    }
}