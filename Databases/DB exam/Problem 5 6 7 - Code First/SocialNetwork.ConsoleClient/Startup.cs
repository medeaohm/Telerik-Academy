namespace SocialNetwork.ConsoleClient
{
    using System.Data.Entity;

    using Data.Migrations;
    using Data;
    using System;
    using Models;

    public class Startup
    {
        public static void Main()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<SocialNetworkDbContext, Configuration>());

            var db = new SocialNetworkDbContext();

            var image = new Image()
            {
                Url = "http:///justTesting",
                Extension = "jpg",
            };

            db.Images.Add(image);
            db.SaveChanges();

            //var savedImages = db.Images.FirstOrDefault();
            //db.Images.Remove(savedImages);
            //db.SaveChanges();
        }
    }
}
