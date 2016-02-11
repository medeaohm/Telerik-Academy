namespace YoutubePlaylists.Data.Migrations
{
    using Microsoft.AspNet.Identity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using YouTubePlaylists.Data.Models;

    public sealed class Configuration : DbMigrationsConfiguration<YoutubePlaylists.Data.YouTubePlaylistsDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(YouTubePlaylistsDbContext context)
        {
            if (context.Users.Any())
            {
                return;
            }


            var passwordHash = new PasswordHasher();
            string password = passwordHash.HashPassword("admin");

            var user = new User()
            {
                UserName = "admin@site.com",
                PasswordHash = password,
                SecurityStamp = "djsabksj"
            };

            context.Users.Add(user);

            context.SaveChanges();

            var seed = new SeedData(user);

            seed.Categories.ForEach(x => context.Categories.Add(x));
            context.SaveChanges();

            seed.Users.ForEach(x => context.Users.Add(x));
            context.SaveChanges();

            seed.Playlists.ForEach(x => context.Playlists.Add(x));
            context.SaveChanges();

            seed.Videos.ForEach(x => context.Videos.Add(x));
            context.SaveChanges();

            seed.Ratings.ForEach(x => context.Ratings.Add(x));
            context.SaveChanges();
        }
    }
}