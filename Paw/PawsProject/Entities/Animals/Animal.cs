using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawsProject
{
    public class Animal
    {
        private string name;
        private int age;
        private int thirdParameter;

        public Animal(string name, int age, int thirdParameter)
        {
            this.name = name;
            this.age = age;
            this.thirdParameter = thirdParameter;
        }

        public string Name
        {
            get { return this.name; }
        }
    }
}
