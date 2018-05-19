using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseworkOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            CatBuilder builder = new CatBuilder();
            builder.Create("Lion1", TypeOfCat.Lion);
            builder.Create("Lion2", TypeOfCat.Lion);
            builder.Create("Lion3", TypeOfCat.Lion);
            builder.Create("Tiger1",TypeOfCat.Tiger);
            builder.Create("Tiger2", TypeOfCat.Tiger);
            builder.Create("Puma", TypeOfCat.Puma);

            Dog dog1 = new Dog("Dog1");
            Dog dog2 = new Dog("Dog2");
            Deer deer1 = new Deer("Deer1");
            Squirrel squirrel1 = new Squirrel("Squirrel1");
            List<IAnimal> animals = Forest.animals;

            Console.Write(String.Format("{0}\t{1}\t{2}\n", "Type", "Name","Eat"));
            foreach (IAnimal animal in animals)
            {
                Console.Write(String.Format("{0}\t{1}\t",animal.Type,animal.Name));
                animal.Eat();
                Console.Write("\t");
                animal.Move();
                Console.Write("\t");
                animal.Say();
                Console.Write("\n");
            }
        }
    }
}
