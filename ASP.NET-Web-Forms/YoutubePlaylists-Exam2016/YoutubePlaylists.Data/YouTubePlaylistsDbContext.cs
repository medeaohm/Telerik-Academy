namespace YoutubePlaylists.Data
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using System.Data.Entity;
    using YouTubePlaylists.Data.Models;

    public class YouTubePlaylistsDbContext : IdentityDbContext<User>
    {
        public YouTubePlaylistsDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public IDbSet<Playlist> Playlists
        {
            get; set;
        }

        public IDbSet<Category> Categories
        {
            get; set;
        }

        public IDbSet<Video> Videos
        {
            get; set;
        }

        public IDbSet<Rating> Ratings
        {
            get; set;
        }

        public static YouTubePlaylistsDbContext Create()
        {
            return new YouTubePlaylistsDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityUserLogin>().HasKey<string>(l => l.UserId);
            modelBuilder.Entity<IdentityRole>().HasKey<string>(r => r.Id);
            modelBuilder.Entity<IdentityUserRole>().HasKey(r => new
            {
                r.RoleId,
                r.UserId
            });

            //modelBuilder.Entity<Rating>()
            //    .HasRequired(c => c.Playlist)
            //    .WithMany()
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Playlist>()
            //    .HasRequired(s => s.Ratings)
            //    .WithMany()
            //    .WillCascadeOnDelete(false);

            modelBuilder
                .Entity<Rating>()
                .HasRequired(p => p.Playlist)
                .WithMany(x => x.Ratings)
                .WillCascadeOnDelete(false);


            //modelBuilder
            //    .Entity<Playlist>()
            //    .HasRequired(p => p.Ratings).WithMany()
            //    .WillCascadeOnDelete(false);

            base.OnModelCreating(modelBuilder);
        }
    }
}
