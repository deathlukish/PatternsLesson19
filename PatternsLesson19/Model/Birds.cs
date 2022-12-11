using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLesson19.Model
{
    internal class Birds : IAnimalClass
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public Birds(string name, string desc, string loation)
        {
            Name = name;
            Description = desc;
            Location = loation;
        }
    }
}
