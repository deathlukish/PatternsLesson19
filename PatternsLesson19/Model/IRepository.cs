using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLesson19.Model
{
    internal interface IRepository
    {
        IEnumerable<IAnimalClass> GetAllAnimal();
    }
}
