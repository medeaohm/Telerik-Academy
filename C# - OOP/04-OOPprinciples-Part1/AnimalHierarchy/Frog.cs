namespace AnimalHierarchy
{
    public class Frog : Animal
    {
        public Frog (string name, int age, Gender gender) : base(name, age, gender)
        {
            this.Type = AnimalType.Frog;
        }

        public override string MakeSound()
        {
            return "Kfa Kfa!";
        }
    }
}
