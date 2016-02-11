namespace LostPets.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Security.Claims;
    using System.Threading.Tasks;

    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Types;
    using System;

    public class User : IdentityUser
    {
        private ICollection<Post> posts;
        private ICollection<Comment> comments;

        public User()
        {
            this.posts = new HashSet<Post>();
            this.comments = new HashSet<Comment>();
        }

        [StringLength(100)]
        public string FirstName { get; set; }

        [StringLength(100)]
        public string LastName { get; set; }

        public string HomeCity { get; set; }

        [DefaultValue(Gender.NotGiven)]
        public Gender Gender { get; set; }

        public string UserRole { get; set; }

        [DefaultValue(false)]
        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public virtual ICollection<Post> Posts
        {
            get
            {
                return this.posts;
            }
            set
            {
                this.posts = value;
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

        public virtual Image ProfilePicture { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<User> manager)
        {
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);

            // Add custom user claims here
            return userIdentity;
        }
    }
}
