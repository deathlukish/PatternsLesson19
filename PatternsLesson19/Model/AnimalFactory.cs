namespace PatternsLesson19.Model
{
    internal static class AnimalFactory
    {
        public static IAnimalClass GetAnimal(EnumAnimal animal,
            string name,
            string desc,
            string location)
        {
            switch (animal)
            {
                case EnumAnimal.Amphibian: return new Amphibians(name, desc, location);
                    break;
                case EnumAnimal.Bird:  return new Birds(name, desc, location);
                    break;
                case EnumAnimal.Mammaml: return new Mammamls(name, desc, location);
                    break;
                default: return new NullAnimal();
                    break;
            }
            return new NullAnimal();
        }
    }
}
