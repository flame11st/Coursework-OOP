using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseworkOOP
{
    class Tiger : Cat
    {
        public Tiger(string name)
        {
            this.Name = name;
            AddToForest();
            Type = "Tiger";
            EatType = new MeatEat();
        }

        public override void Say()
        {
            Console.Write("Tiger say");
        }
        public override void Move()
        {
            Console.Write("Tiger move");
        }
        public override void AddToForest()
        {
            Forest.AddAnimal(this);
        }
    }
}
