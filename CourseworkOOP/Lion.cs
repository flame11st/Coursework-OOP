using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseworkOOP
{
    class Lion : Cat
    {
        public Lion(string name)
        {
            this.Name = name;
            AddToForest();
            Type = "Lion";
            EatType = new MeatEat();
        }

        public override void Say()
        {
            Console.Write("Lion say");
        }
        public override void Move()
        {
            Console.Write("Lion move");
        }
        public override void AddToForest()
        {
            Forest.AddAnimal(this);
        }
    }
}
