namespace BullsAndCows.Web.Api
{
    using System.Data.Entity;
    using BullsAndCows.Data;
    using BullAndCows.Data.Migrations;

    public static class DatabaseConfig
    {
        public static void Initialize()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<BullsAndCowsDbContext, Configuration>());
        }
    }
}