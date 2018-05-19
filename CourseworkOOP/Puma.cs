using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseworkOOP
{
    class Puma : Cat
    {
        public Puma(string name)
        {
            this.Name = name;
            AddToForest();
            Type = "Puma";
            EatType = new MeatEat();
        }

        public override void Say()
        {
            Console.Write("Puma say");
        }
        public override void Move()
        {
            Console.Write("Puma move");
        }
        public override void AddToForest()
        {
            Forest.AddAnimal(this);
        }
    }
}
