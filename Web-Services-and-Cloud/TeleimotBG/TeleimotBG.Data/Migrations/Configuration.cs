namespace TeleimotBG.Data.Migrations
{
    using System.Data.Entity.Migrations;

    public sealed class Configuration : DbMigrationsConfiguration<TeleimotBG.Data.TeleimotBGDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "TeleimotBG.Data.TeleimotBGDbContext";
            AutomaticMigrationDataLossAllowed = false;
        }
    }
}
