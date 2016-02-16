namespace LostPets.Data.Models.Types
{
    using System.ComponentModel.DataAnnotations;

    public enum BirdType
    {
        [Display(Name ="Other")]
        NotGiven = 0,
        Parrot = 1,
        Canaries = 2,
        Finches = 3,
        Tit = 4,
        Crow = 5,
        Eagle = 6
    }
}
