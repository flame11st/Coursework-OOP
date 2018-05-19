using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseworkOOP
{
    class Dog : IAnimal
    {
        public string Name { get; set; }
        public string Type { get; private set; }
        private IEatable EatType { get; set; }

        public Dog(string name)
        {
            this.Name = name;
            AddToForest();
            Type = "dog";
            EatType = new MeatEat();
        }

        public void Say()
        {
            Console.Write("Dog say");
        }

        public void Move()
        {
            Console.Write("Dog move");
        }

        public void AddToForest()
        {
            Forest.AddAnimal(this);
        }

        public void Eat()
        {
            EatType.Eat();
        }
    }
}
