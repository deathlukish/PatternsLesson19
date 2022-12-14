using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLesson19.Model
{
    internal class BaseSaver
    {
        IBaseSave baseSave;
        public BaseSaver(IBaseSave baseSave)
        {
            this.baseSave = baseSave;
        }
        public void Save(IRepository repository)
        {
            baseSave.Save(repository);
        }
    }
}
