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
        Repository repository;
        List<IAnimalClass> _animalClasses = new();
        public List<IAnimalClass> AnimalClasses
        {
            get => _animalClasses;
            set => Set(ref _animalClasses, value);
        }
        public Array Classes { get; }
        public Array TypeFiles { get; }
        public EnumAnimal _class;
        private EnumTypeFile _typeFile;
        public EnumTypeFile TypeFile 
        {
            get => _typeFile;
            set => Set(ref _typeFile, value);
        }
        public EnumAnimal Class
        {
            get => _class;
            set => Set(ref _class, value);
        }
        public ICommand AddAnimal { get; }
        private void OnAddAnimal(object p)
        {
            _animalClasses.Add(AnimalFactory.GetAnimal(Class, "", "", ""));
        }
        private bool CanAddAnimal(object p)
        {

            if (Class == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public ICommand SaveAll { get; }
        private void OnSaveAll(object p)
        {
            IBaseSave baseSave = null;
            switch (TypeFile)
            {
                case EnumTypeFile.Xml: 
                    baseSave = new SaveXml();
                    break;
                case EnumTypeFile.Json:
                    baseSave = new SaveJson();
                    break;
                default:
                    break;
            }
            baseSave.Save(repository);
        }
       
        private bool CanSaveAll(object p)
        {
            if (TypeFile == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public MainWindowViewModel()
        {
            repository = new Repository();
            Classes = Enum.GetValues(typeof(EnumAnimal));
            TypeFiles = Enum.GetValues(typeof(EnumTypeFile));
            AddAnimal = new RelayCommand(OnAddAnimal, CanAddAnimal);
            SaveAll = new RelayCommand(OnSaveAll, CanSaveAll);
        }

    }
}
