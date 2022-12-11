namespace PatternsLesson19.Model
{
    internal class NullAnimal : IAnimalClass
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public NullAnimal()
        {
            this.Name = "Unknow";
            this.Description = "Unknow";
            this.Location = "Unknow";
        }
    }
}
