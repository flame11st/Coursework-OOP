using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseworkOOP
{
    class LionBuilder : ICatBuilder
    {
        public Cat Create(string name)
        {
            return new Lion(name);
        }
    }
}
