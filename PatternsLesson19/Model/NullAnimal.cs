namespace PatternsLesson19.Model
{
    internal class NullAnimal : IAnimalClass
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public NullAnimal()
        {
            Name = "Unknow";
            Description = "Unknow";
            Location = "Unknow";
        }
        public override string ToString()
        {
            return $"{Name} {Description} {Location}";
        }
    }
}
