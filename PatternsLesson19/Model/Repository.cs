using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace PatternsLesson19.Model
{

    internal class Repository : IRepository
    {
        IEnumerable<IAnimalClass>? _db;
        readonly string _pathBase = "./base.json";
        public Repository()
        {
            LoadBase();
        }

        public IEnumerable<IAnimalClass> GetAllAnimal()
        {
            return _db;
        }
        public IEnumerable<IAnimalClass> LoadBase()
        {
            if (!File.Exists(_pathBase))
            {
                using (FileStream fs = File.Create(_pathBase))
                {

                }
            }
            JsonSerializerSettings setting = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All

            };
            using (StreamReader streamReader = new StreamReader(_pathBase))
            {
                _db = JsonConvert.DeserializeObject<IEnumerable<IAnimalClass>>(streamReader.ReadToEnd(), setting);

            }
            if (_db == null)
            {
                _db = new List<IAnimalClass>();
            }
            return _db;
        }
        public void SaveBase(IEnumerable<IAnimalClass>? db)
        {
            using (StreamWriter fs = new StreamWriter(_pathBase))
            {
            JsonSerializerSettings setting = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All

            };
                var jsonString = JsonConvert.SerializeObject(db, Formatting.Indented, setting);
                fs.WriteLine(jsonString);
            }
        }
    }
}
