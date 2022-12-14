using System.IO;
using System.Text;

namespace PatternsLesson19.Model
{
    internal class SaveTxt : IBaseSave
    {
        public void Save(IRepository repository)
        {
            StringBuilder stringBuilder = new StringBuilder();
            using (StreamWriter fs = new StreamWriter("./save.txt"))
            {

                foreach (var item in repository.GetAllAnimal())
                {

                    fs.WriteLine(item.ToString());

                }
            }

        }
    }
}
