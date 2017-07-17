using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawsProject
{
    public class CommandInterpreter
    {
        private List<Center> centers;
        private AnimalFactory animalFactory;
        private List<Animal> animals;
        private List<string> adoptionCenter = new List<string>();
        private SortedSet<string> adoptedAnimals;
        private SortedSet<string> cleansedAnimals;

        public CommandInterpreter()
        {
            this.centers = new List<Center>();
            this.animalFactory = new AnimalFactory();
            this.animals = new List<Animal>();
            this.adoptedAnimals = new SortedSet<string>();
            this.cleansedAnimals = new SortedSet<string>();
        }

        public void GetCommand(string inputLine)
        {
            var commandArgs = inputLine.Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
            var commandType = commandArgs[0].Trim();

            switch (commandType)
            {
                case "RegisterAdoptionCenter":
                    centers.Add(new AdoptionCenter(commandArgs[1].Trim()));
                    break;
                case "RegisterCleansingCenter":
                    centers.Add(new CleansingCenter(commandArgs[1].Trim()));
                    break;
                case "RegisterDog":
                case "RegisterCat":
                    var currentAnimal = animalFactory.RegAnimal(commandArgs[1].Trim(), int.Parse(commandArgs[2].Trim()), int.Parse(commandArgs[3].Trim()));

                    if (centers.Any(c => c.Name == commandArgs[4].Trim()))
                    {
                        centers.Single(c => c.Name == commandArgs[4].Trim()).AddAnimal(currentAnimal);
                    }
                    break;
                case "SendForCleansing":
                    List<Animal> animalsForCleanse = centers.Single(c => c.Name == commandArgs[1].Trim()).GetAnimals();
                    centers.Single(c => c.Name == commandArgs[2].Trim()).AddRangeOfAnimals(animalsForCleanse);
                    centers.Single(c => c.Name == commandArgs[1].Trim()).RemoveUncleanseAnimals();
                    adoptionCenter.Add(commandArgs[1].Trim());
                    break;
                case "Cleanse":
                    List<Animal> animalsForAdoption = centers.Single(c => c.Name == commandArgs[1].Trim()).GetAnimals();
                    centers.Single(c => c.Name == adoptionCenter[0]).AddRangeOfAnimals(animalsForAdoption);
                    adoptionCenter.RemoveAt(0);

                    foreach (var cleansedAnimal in animalsForAdoption)
                    {
                        this.cleansedAnimals.Add(cleansedAnimal.Name);
                    }

                    centers.Single(c => c.Name == commandArgs[1].Trim()).RemoveAnimals();

                    break;
                case "Adopt":
                    List<Animal> adoptedAnimals = centers.Single(c => c.Name == commandArgs[1].Trim()).GetCleansedAnimals();

                    foreach (var adoptedAnimal in adoptedAnimals)
                    {
                        this.adoptedAnimals.Add(adoptedAnimal.Name);
                    }

                    centers.Single(c => c.Name == commandArgs[1].Trim()).RemoveAnimals();
                    break;
            }
        }

        public string GetStatistic()
        {
            var adoptionCenters = centers.Where(c => c.GetType().Name == "AdoptionCenter").ToList();
            var waitingForAdoptionAnimals = adoptionCenters.Sum(x => x.GetAnimalsCount());
            var cleansedCenters = centers.Where(c => c.GetType().Name == "CleansingCenter").ToList();
            var waitingForCleansedAnimals = cleansedCenters.Sum(x => x.GetAnimalsCount());

            var sb = new StringBuilder();
            sb.AppendLine("Paw Incorporative Regular Statistics");
            sb.AppendLine($"Adoption Centers: {centers.Where(c => c.GetType().Name == "AdoptionCenter").ToList().Count}");
            sb.AppendLine($"Cleansing Centers: {centers.Where(c => c.GetType().Name == "CleansingCenter").ToList().Count}");
            if (this.adoptedAnimals.Any())
            {
                sb.AppendLine($"Adopted Animals: {string.Join(", ", this.adoptedAnimals)}");
            }
            else
            {
                sb.AppendLine($"Adopted Animals: None");
            }

            if (this.cleansedAnimals.Any())
            {
                sb.AppendLine($"Cleansed Animals: {string.Join(", ", this.cleansedAnimals)}");
            }
            else
            {
                sb.AppendLine($"Cleansed Animals: None");
            }

            sb.AppendLine($"Animals Awaiting Adoption: {waitingForAdoptionAnimals}");
            sb.AppendLine($"Animals Awaiting Cleansing: {waitingForCleansedAnimals}");

            return sb.ToString().Trim();
        }
    }
}