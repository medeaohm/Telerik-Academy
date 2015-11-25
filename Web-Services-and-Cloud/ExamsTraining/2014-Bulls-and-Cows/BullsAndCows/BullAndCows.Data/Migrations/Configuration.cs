namespace BullAndCows.Data.Migrations
{
    using BullsAndCows.Data;
    using System.Data.Entity.Migrations;

    public sealed class Configuration : DbMigrationsConfiguration<BullsAndCowsDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "BullsAndCows.Data.BullsAndCowsDbContext";
            AutomaticMigrationDataLossAllowed = false;
        }
    }
}
