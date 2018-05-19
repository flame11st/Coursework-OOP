using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseworkOOP
{
    abstract class Cat : IAnimal
    {
        public string Name { get; set; }
        public string Type { get; protected set; }
        protected IEatable EatType { get; set; }

        abstract public void Say();
        abstract public void Move();

        abstract public void AddToForest();

        public void Eat()
        {
            EatType.Eat();
        }
    }
}
