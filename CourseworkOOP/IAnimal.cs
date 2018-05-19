using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseworkOOP
{
    interface IAnimal : IEatable, IMoveble, ISpeaking
    {
        string Type { get;}
        string Name { get; set; }
        void AddToForest();
    }
}
