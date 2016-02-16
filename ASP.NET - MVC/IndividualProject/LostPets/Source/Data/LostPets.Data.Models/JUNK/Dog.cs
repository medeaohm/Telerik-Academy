namespace LostPets.Data.Models
{
    using System.ComponentModel;
    using Types;

    public class Dog : Pet
    {
        [DefaultValue(DogType.NotGiven)]
        public DogType DogType { get; set; }
    }
}
