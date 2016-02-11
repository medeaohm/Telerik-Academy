namespace LostPets.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using Types;

    public class Location
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public City City { get; set; }

        public string Street { get; set; }

        public string AdditionalInfo { get; set; }
    }
}
