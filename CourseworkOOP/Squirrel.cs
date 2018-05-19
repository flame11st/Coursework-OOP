using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseworkOOP
{
    class Squirrel :IAnimal
    {

        public string Type { get; private set; }
        public string Name { get; set; }
        private IEatable EatType { get; set; }

        public Squirrel(string name)
        {
            this.Name = name;
            AddToForest();
            Type = "Squirrel";
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
