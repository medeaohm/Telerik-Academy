namespace YoutubePlaylists.Data.Repositories
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    using YouTubePlaylists.Data.Models;

    public interface IYouTubePlaylistsDbContext : IDisposable
    {
        int SaveChanges();

        IDbSet<User> Users
        {
            get; set;
        }

        IDbSet<Category> Categories
        {
            get; set;
        }

        IDbSet<Playlist> Playlists
        {
            get; set;
        }

        IDbSet<Video> Videos
        {
            get; set;
        }

        IDbSet<Rating> Ratings
        {
            get; set;
        }

        DbSet<TEntity> Set<TEntity>() where TEntity : class;

        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
    }
}