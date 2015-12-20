namespace TeleimotBG.Models
{
    using System.Security.Claims;
    using System.Threading.Tasks;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System.Collections.Generic;

    public class User : IdentityUser
    {
        private ICollection<RealEstate> realEstates;
        private ICollection<Comment> comments;

        public User()
        {
            this.realEstates = new HashSet<RealEstate>();
            this.comments = new HashSet<Comment>();
        } 

        public virtual ICollection<RealEstate> RealEstates
        {
            get
            {
                return this.realEstates;
            }
            set
            {
                this.realEstates = value;
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

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<User> manager, string authenticationType)
        {
            var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);
            return userIdentity;
        }
    }
}
