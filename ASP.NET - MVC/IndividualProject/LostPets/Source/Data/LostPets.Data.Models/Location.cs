namespace LostPets.Data.Models
{
    using Common.Models;
    using System.ComponentModel.DataAnnotations;

    using Types;

    public class Location : BaseModel<int>
    {
        [Required]
        public City City { get; set; }

        public string Street { get; set; }

        public string AdditionalInfo { get; set; }
    }
}
