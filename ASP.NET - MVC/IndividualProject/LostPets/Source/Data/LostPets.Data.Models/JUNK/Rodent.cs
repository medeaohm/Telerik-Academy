namespace LostPets.Data.Models
{
    using System.ComponentModel;

    using Types;

    public class Rodent : Pet
    {
        [DefaultValue(RodentType.NotGiven)]
        public RodentType RodentType { get; set; }
    }
}
