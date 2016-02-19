namespace LostPets.Data.Models
{
    using System.ComponentModel;
    using Types;

    public class Cat : Pet
    {
        [DefaultValue(CatType.NotGiven)]
        public CatType CatType { get; set; }
    }
}
