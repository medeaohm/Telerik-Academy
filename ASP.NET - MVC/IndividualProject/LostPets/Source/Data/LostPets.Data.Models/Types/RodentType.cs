namespace LostPets.Data.Models.Types
{
    using System.ComponentModel.DataAnnotations;

    public enum RodentType
    {
        [Display(Name ="Other")]
        NotGiven = 0,
        Rabbit = 1,
        Mouse = 2,
        Hamster = 3,
        GuineaPig = 4,
        Polecat = 5 // пор
    }
}
