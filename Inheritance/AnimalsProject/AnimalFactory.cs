using System;

namespace AnimalsProject
{
    public static class AnimalFactory
    {
        public static Animal Get(string animalType, string name, int age, string gender)
        {
            switch (animalType)
            {
                case "Cat":
                    return new Cat(name, age, gender);
                case "Dog":
                    return new Dog(name, age, gender);
                case "Frog":
                    return new Frog(name, age, gender);
                case "Kitten":
                    return new Kitten(name, age, gender);
                case "Tomcat":
                    return new Tomcat(name, age, gender);
                default:
                    throw new ArgumentException("Invalid input!");
            }
        }
    }
}