using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLesson19.Model
{
    internal class Repository: IRepository
    {
        List<IAnimalClass>? _db;
        public Repository()
        { 
        
        }

        public IEnumerable<IAnimalClass> GetAllAnimal()
        {
            return _db;
        }
        public IEnumerable<IAnimalClass> LoadBase()
        {
            return _db;
        }
       
    }
}
