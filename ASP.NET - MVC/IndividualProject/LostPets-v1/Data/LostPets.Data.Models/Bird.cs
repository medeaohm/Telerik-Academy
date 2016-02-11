namespace LostPets.Data.Models
{
    using System.ComponentModel;
    using Types;

    public class Bird : Pet
    {
        [DefaultValue(BirdType.NotGiven)]
        public BirdType BirdType { get; set; }
    }
}
