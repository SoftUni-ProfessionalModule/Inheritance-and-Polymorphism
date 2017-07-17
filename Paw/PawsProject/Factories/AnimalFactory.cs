using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawsProject
{
    public class AnimalFactory
    {
        Animal currentAnimal = null;

        public Animal RegAnimal(string name, int age, int thirdParameter)
        {
            return currentAnimal = new Animal(name, age, thirdParameter);
        }
    }
}