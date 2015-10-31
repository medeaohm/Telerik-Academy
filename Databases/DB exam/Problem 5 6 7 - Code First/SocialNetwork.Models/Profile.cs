namespace SocialNetwork.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Profile
    {
        private ICollection<Image> images;
        private ICollection<Post> postsTaggedIn;

        public Profile()
        {
            this.images = new List<Image>();
            this.postsTaggedIn = new List<Post>();
        }

        [Key]
        [Required]
        [MinLength(4)]
        [MaxLength(20)]
        public string Username
        {
            get; set;
        }

        [MinLength(2)]
        [MaxLength(50)]
        public string FirtsName
        {
            get; set;
        }

        [MinLength(2)]
        [MaxLength(50)]
        public string LastName
        {
            get; set;
        }

        public DateTime registrationDate
        {
            get; set;
        }

        public virtual ICollection<Image> Images
        {
            get
            {
                return this.images;
            }
            set
            {
                this.images = value;
            }
        }

        public virtual ICollection<Post> PostsTaggedIn
        {
            get
            {
                return this.postsTaggedIn;
            }
            set
            {
                this.postsTaggedIn = value;
            }
        }
    }
}
