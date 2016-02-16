namespace LostPets.Data.Models
{
    using Types;
    using System.ComponentModel;

    public class Cat : Pet
    {
        [DefaultValue(CatType.NotGiven)]
        public CatType CatType { get; set; }
    }
}
