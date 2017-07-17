using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawsProject
{
    public class AdoptionCenter : Center
    {
        private List<Animal> unCleansedAnimals;
        private List<Animal> cleansedAnimals;

        public AdoptionCenter(string name) 
            : base(name)
        {
            this.unCleansedAnimals = new List<Animal>();
            this.cleansedAnimals = new List<Animal>();
        }

        public List<Animal> Animals
        {
            get { return this.unCleansedAnimals; }
        }

        public override void AddAnimal(Animal animal)
        {
            this.unCleansedAnimals.Add(animal);
        }

        public override void AddRangeOfAnimals(List<Animal> animals)
        {
            this.cleansedAnimals.AddRange(animals);
        }

        public override List<Animal> GetAnimals()
        {
            return this.unCleansedAnimals;
        }

        public override int GetAnimalsCount()
        {
            return this.unCleansedAnimals.Count;
        }

        public override void RemoveAnimals()
        {
            this.cleansedAnimals.Clear();
        }

        public override List<Animal> GetCleansedAnimals()
        {
            return this.cleansedAnimals;
        }

        public override void RemoveUncleanseAnimals()
        {
            this.unCleansedAnimals.Clear();
        }
    }
}