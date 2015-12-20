namespace TeleimotBG.Data
{
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    using TeleimotBG.Models;

    public interface ITeleimotBGDbContext
    {
        IDbSet<User> Users
        {
            get; set;
        }

        DbSet<TEntity> Set<TEntity>() where TEntity : class;

        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;

        int SaveChanges();

        void Dispose();
    }
}

