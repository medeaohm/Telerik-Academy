namespace LostPets.Data.Models
{
    using System;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public class Comment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(1000, MinimumLength = 2)]
        public string Content { get; set; }

        public DateTime CreatedOn { get; set; }

        public string AuthorId { get; set; }

        public virtual User Author { get; set; }

        public int PostId { get; set; }

        public virtual Post Post { get; set; }
        
        [DefaultValue(false)]
        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
