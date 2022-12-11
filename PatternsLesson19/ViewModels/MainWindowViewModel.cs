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
        List<IAnimalClass> _animalClasses = new();
        public List<IAnimalClass> AnimalClasses
        {
            get => _animalClasses;
            set => Set(ref _animalClasses, value);
        }
        private Array _Classes;
        public Array Classes { get; set; }
        public EnumAnimal Class { get; set; }
        public ICommand AddAnimal { get; }
        private void OnAddAnimal(object p)
        {
            _animalClasses.Add(AnimalFactory.GetAnimal(Class, "", "", ""));
        }
        private bool CanAddAnimal(object p)

        {

            if (Class == null) return false;
            else
            {
                return true;
            }
        }
        public MainWindowViewModel()
        {
            Classes = Enum.GetValues(typeof(EnumAnimal));
            AddAnimal = new RelayCommand(OnAddAnimal, CanAddAnimal);
        }

    }
}
