using PatternsLesson19.Commands;
using PatternsLesson19.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PatternsLesson19.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        private Array _Classes;
        public Array Classes { get; set; }
        public EnumAnimal Class { get; set; }
        public ICommand AddMammal { get; }
        private void OnAddMammal(object p)
        {
           
        }
        private bool CanAddMammal(object p) => true;
        public MainWindowViewModel()
        {
            Classes = Enum.GetValues(typeof(EnumAnimal));
            AddMammal = new RelayCommand(OnAddMammal, CanAddMammal);
        }

    }
}
