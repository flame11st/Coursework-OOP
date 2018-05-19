using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseworkOOP
{
    class Deer :IAnimal
    {

        public string Type { get; private set; }
        public string Name { get; set; }
        private IEatable EatType { get; set; }

        public Deer(string name)
        {
            this.Name = name;
            AddToForest();
            Type = "Deer";
            EatType = new HerbsEat();
        }

        public void AddToForest()
        {
            Forest.AddAnimal(this);
        }

        public void Eat()
        {
            EatType.Eat();
        }

        public void Move()
        {
            Console.Write("Deer moves.");
        }

        public void Say()
        {
            Console.Write("Deer say.");
        }
    }
}
