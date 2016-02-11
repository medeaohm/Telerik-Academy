namespace TicketingSystem.Models
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Security.Claims;
    using System.Threading.Tasks;

    public class User : IdentityUser
    {
        private ICollection<Ticket> tickets;
        private ICollection<Comment> comment;

        public User()
        {
            this.tickets = new HashSet<Ticket>();
            this.comment = new HashSet<Comment>();
        }

        [DefaultValue(10)]
        public int Points
        {
            get; set;
        }

        public virtual ICollection<Ticket> Tickets
        {
            get
            {
                return this.tickets;
            }
            set
            {
                this.tickets = value;
            }
        }

        public virtual ICollection<Comment> Comments
        {
            get
            {
                return this.comment;
            }
            set
            {
                this.comment = value;
            }
        }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<User> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }
}
