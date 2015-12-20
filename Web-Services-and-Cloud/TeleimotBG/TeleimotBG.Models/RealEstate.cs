namespace TeleimotBG.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class RealEstate
    {
        private ICollection<Comment> comments;

        public RealEstate()
        {
            this.comments = new HashSet<Comment>();
        }

        [Key]
        public int RealEstateId
        {
            get; set;
        }

        [Required]
        [MinLength(5)]
        [MaxLength(50)]
        public string Title
        {
            get; set;
        }

        [Required]
        [MinLength(10)]
        [MaxLength(1000)]
        public string Description
        {
            get; set;
        }

        public RealEstateType RealEstateType
        {
            get; set;
        }

        //•	Real estate construction year is minimum 1800.
        [Range(1800, int.MaxValue)]
        public int YearOfContruction
        {
            get; set;
        }

        [Required]
        public string Address
        {
            get; set;
        }

        [Required]
        public string Contact
        {
            get; set;
        }

        public int? SellingPrice
        {
            get; set;
        }

        public int? RentingPrice
        {
            get; set;
        }

        public bool CanBeSold
        {
            get; set;
        }

        public bool CanBeRented
        {
            get; set;
        }

        public DateTime CreatedOn
        {
            get; set;
        }

        public virtual ICollection<Comment> Comments
        {
            get
            {
                return this.comments;
            }
            set
            {
                this.comments = value;
            }
        }
    }
}
