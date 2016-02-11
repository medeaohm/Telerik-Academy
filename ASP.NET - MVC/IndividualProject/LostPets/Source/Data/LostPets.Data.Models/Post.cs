namespace LostPets.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel;
    using Types;
    using Common.Models;

    public class Post : BaseModel<int>
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

        [Required]
        [StringLength(100, MinimumLength = 5)]
        public string Title { get; set; }

        [Required]
        public PostType PostType { get; set; }

        [Required]
        [DefaultValue(AnimalType.NotGiven)]
        public AnimalType AnimalType { get; set; }

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
