using PatternsLesson19.Commands;
using PatternsLesson19.Model;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace PatternsLesson19.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        Repository repository;
        ObservableCollection<IAnimalClass> _allAnimal = new();
        string _name;
        string _description;
        string _location;
        public string Name
        {
            get => _name;
            set => Set(ref _name, value);
        }
        public string Description
        {
            get { return _description; }
            set => Set(ref _description, value);
        }
        public string Location
        {
            get => _location;
            set => Set(ref _location, value);
        }
        public ObservableCollection<IAnimalClass> AllAnimal
        {
            get => _allAnimal;
            set => Set(ref _allAnimal, value);
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
            AllAnimal.Add(AnimalFactory.GetAnimal(Class, Name, Description, Location));
            repository.SaveBase(AllAnimal);
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
                case EnumTypeFile.Txt:
                    baseSave = new SaveTxt();
                    break;
                case EnumTypeFile.Json:
                    baseSave = new SaveJson();
                    break;
                default:
                    break;
            }
            BaseSaver baseSaver = new(baseSave);
            baseSaver.Save(repository);
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
            foreach (var animal in repository.GetAllAnimal())
            {
                AllAnimal.Add(animal);
            }
            Classes = Enum.GetValues(typeof(EnumAnimal));
            TypeFiles = Enum.GetValues(typeof(EnumTypeFile));
            AddAnimal = new RelayCommand(OnAddAnimal, CanAddAnimal);
            SaveAll = new RelayCommand(OnSaveAll, CanSaveAll);
        }

    }
}
