using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseworkOOP
{
    class TigerBuilder : ICatBuilder
    {
        public Cat Create(string name)
        {
            return new Tiger(name);
        }
    }
}
