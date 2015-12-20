namespace TeleimotBG.Data
{
    using Models;
    using Microsoft.AspNet.Identity.EntityFramework;

    public class TeleimotBGDbContext : IdentityDbContext<User>, ITeleimotBGDbContext
    {
        public TeleimotBGDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static TeleimotBGDbContext Create()
        {
            return new TeleimotBGDbContext();
        }
    }
}
