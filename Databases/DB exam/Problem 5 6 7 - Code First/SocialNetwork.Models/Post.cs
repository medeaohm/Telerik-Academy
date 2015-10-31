namespace SocialNetwork.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Post
    {
        private ICollection<Profile> usersTagged;

        public Post()
        {
            this.usersTagged = new HashSet<Profile>();
        }

        public int Id
        {
            get; set;
        }

        [Required]
        [MinLength(10)]
        public string Content
        {
            get; set;
        }

        [Required]
        public DateTime PostingDate
        {
            get; set;
        }

        public virtual ICollection<Profile> UsersTagged
        {
            get
            {
                return this.usersTagged;
            }
            set
            {
                this.usersTagged = value;
            }
        }
    }
}
