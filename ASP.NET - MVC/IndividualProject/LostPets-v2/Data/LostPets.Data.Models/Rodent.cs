namespace LostPets.Data.Models
{
    using Types;

    using System.ComponentModel;

    public class Rodent : Pet
    {
        [DefaultValue(RodentType.NotGiven)]
        public RodentType RodentType { get; set; }
    }
}
