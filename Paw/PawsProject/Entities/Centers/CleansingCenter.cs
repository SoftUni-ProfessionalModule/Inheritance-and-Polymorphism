using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawsProject
{
    public class CleansingCenter : Center
    {
        private List<Animal> animals;

        public CleansingCenter(string name)
            : base(name)
        {
            this.animals = new List<Animal>();
        }

        public List<Animal> Animals
        {
            get { return this.animals; }
        }

        public override void AddAnimal(Animal animal)
        {
            this.animals.Add(animal);
        }

        public override void AddRangeOfAnimals(List<Animal> animals)
        {
            this.animals.AddRange(animals);
        }

        public override List<Animal> GetAnimals()
        {
            return this.animals;
        }

        public override int GetAnimalsCount()
        {
            return this.animals.Count;
        }

        public override void RemoveAnimals()
        {
            this.animals.Clear();
        }
    }
}
