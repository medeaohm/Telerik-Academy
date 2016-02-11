namespace YouTubePlaylists.Web.App_Start
{
    using System.Data.Entity;
    using YoutubePlaylists.Data;
    using YoutubePlaylists.Data.Migrations;

    public class DbConfig
    {
        public static void Initialize()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<YouTubePlaylistsDbContext, Configuration>());
            YouTubePlaylistsDbContext.Create().Database.Initialize(true);
        }
    }
}