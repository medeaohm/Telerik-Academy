namespace MusicSystem.ConsoleClient
{
    using System.Data.Entity;
    using Data.Migrations;
    using System.Linq;

    using Models;
    using Data;

    public class StartUp
    {
        public static void Main()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MusicSystemDbContext,Configuration>());

            var db = new MusicSystemDbContext();

            var artist = new Artist()
            {
                Name = "Sahka",
                Country = "Dupnica",
            };

            //db.Artists.Add(artist);
            //db.SaveChanges();

            //var savedArtists = db.Artists.FirstOrDefault();
            //db.Artists.Remove(savedArtists);
            //db.SaveChanges();
        }
    }
}
