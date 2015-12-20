namespace TeleimotBG.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Comment
    {
        [Key]
        public int CommentId
        {
            get; set;
        }

        [Required]
        [MinLength(10)]
        [MaxLength(500)]
        public string Content
        {
            get; set;
        }

        public DateTime CreatedOn
        {
            get; set;
        }

        public int UserId
        {
            get; set;
        }

        public virtual User User
        {
            get; set;
        }

        public int RealEstateId
        {
            get; set;
        }

        public virtual RealEstate RealEstate
        {
            get; set;
        }

    }
}
