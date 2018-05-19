using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseworkOOP
{
    class CatBuilder
    {
        public Cat Create(string name, TypeOfCat type)
        {
            switch (type)
            {
                case TypeOfCat.Lion:
                    return new LionBuilder().Create(name);
                case TypeOfCat.Puma:
                    return new PumaBuilder().Create(name);
                case TypeOfCat.Tiger:
                    return new TigerBuilder().Create(name);
                default:
                    return new LionBuilder().Create(name);
            }
        }
    }

}
