namespace WebChat.Models
{
    using System.Data.Entity;

    public class WebChatDbContext : DbContext
    {
        public WebChatDbContext()
            : base("WebChatDbContext")
        {
        }

        public DbSet<Message> Messages
        {
            get; set;
        }

        public DbSet<User> Users
        {
            get; set;
        }
    }
}