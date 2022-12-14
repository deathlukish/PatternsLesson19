using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLesson19.Model
{
    internal class SaveJson : IBaseSave
    {
        public void Save(IRepository repository)
        {
            var jsonString = JsonConvert.SerializeObject(repository.GetAllAnimal());
            using (StreamWriter fs = new StreamWriter("./save.json"))
            {
                fs.WriteLine(jsonString);
            }

        }
    }
}
