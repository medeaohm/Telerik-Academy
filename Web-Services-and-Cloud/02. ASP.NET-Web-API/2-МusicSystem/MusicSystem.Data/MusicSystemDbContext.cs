namespace MusicSystem.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;

    using Models;

    public class MusicSystemDbContext : DbContext
    {
        public MusicSystemDbContext()
            : base("MusicSystemConnection")
        {
        }

        public DbSet<Album> Albums
        {
            get; set;
        }

        public DbSet<Song> Songs
        {
            get; set;
        }

        public DbSet<Artist> Artists
        {
            get; set;
        }
    }
}
