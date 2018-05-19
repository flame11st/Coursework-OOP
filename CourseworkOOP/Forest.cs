using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseworkOOP
{
    class Forest
    {
        private static Forest instance;

        public static List<IAnimal> animals { get; private set; }
        public static int countAnimals { get; private set; }
        public static void AddAnimal(IAnimal animal)
        {
            if (instance == null)
            {
                instance = new Forest();
            }  
            animals.Add(animal);
            countAnimals = animals.Count;
        }

        private Forest()
        {
            countAnimals = 0;
            animals = new List<IAnimal>();
        }
    }
}
