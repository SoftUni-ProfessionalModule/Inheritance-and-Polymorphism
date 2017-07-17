using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawsProject
{
    public abstract class Center
    {
        private string name;

        public Center(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public virtual List<Animal> GetCleansedAnimals()
        {
            return null;
        }

        public virtual void RemoveUncleanseAnimals()
        {
            
        }
        public abstract int GetAnimalsCount();

        public abstract void AddAnimal(Animal animal);

        public abstract void RemoveAnimals();

        public abstract List<Animal> GetAnimals();

        public abstract void AddRangeOfAnimals(List<Animal> animals);
    }
}
