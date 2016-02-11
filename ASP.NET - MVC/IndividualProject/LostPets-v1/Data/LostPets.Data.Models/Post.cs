namespace LostPets.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel;
    using Types;

    public class Post
    {
        private ICollection<Image> gallery;
        private ICollection<Location> locations;
        private ICollection<Comment> comments;

        public Post()
        {
            this.gallery = new HashSet<Image>();
            this.locations = new HashSet<Location>();
            this.comments = new HashSet<Comment>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 5)]
        public string Title { get; set; }

        [Required]
        public PostType PostType { get; set; }

        [Required]
        [DefaultValue(AnimalType.NotGiven)]
        public AnimalType AnimalType { get; set; }

        public DateTime CreatedOn { get; set; }

        [DefaultValue(false)]
        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public int AuthorId { get; set; }

        public virtual User Author { get; set; }

        public virtual ICollection<Image> Gallery
        {
            get
            {
                return this.gallery;
            }
            set
            {
                this.gallery = value;
            }
        }

        public virtual ICollection<Location> Locations
        {
            get
            {
                return this.locations;
            }
            set
            {
                this.locations = value;
            }
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
