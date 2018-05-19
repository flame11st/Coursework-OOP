using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseworkOOP
{
    class HerbsEat : IEatable
    {
        public void Eat()
        {
            Console.Write("Eating herbs");
        }
    }
}
