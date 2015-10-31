namespace SocialNetwork.Data
{
    using System.Data.Entity;
    using System.Linq;

    using SocialNetwork.Models;
    using System;
    using System.Data.Entity.ModelConfiguration.Conventions;

    public class SocialNetworkDbContext : DbContext
    {
        public SocialNetworkDbContext()
            : base("SocialNetworkConnection")
        {
        }

        public DbSet<Profile> Profiles
        {
            get; set;
        }

        public DbSet<Image> Images
        {
            get; set;
        }

        public DbSet<Post> Posts
        {
            get; set;
        }

        public DbSet<Friedship> Fiendships
        {
            get; set;
        }

        public DbSet<ChatMessage> ChatMessages
        {
            get; set;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
        }
    }
}
