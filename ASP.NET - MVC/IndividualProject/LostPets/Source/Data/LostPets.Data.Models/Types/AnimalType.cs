namespace LostPets.Data.Models.Types
{
    using System.ComponentModel.DataAnnotations;

    public enum AnimalType
    {
        [Display(Name = "Not Given")]
        NotGiven = 0,
        Dog = 1,
        Cat = 2,
        Rodent = 3,
        Bird = 4,
    }
}
