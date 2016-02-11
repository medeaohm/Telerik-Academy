using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubePlaylists.Data.Repositories;
using YouTubePlaylists.Data.Models;
using YouTubePlaylists.Data.Services.Contracts;

namespace YouTubePlaylists.Data.Services
{
    public class PlaylistServices : IPlaylistServices
    {
        private IRepository<Playlist> playlists;

        public PlaylistServices(IRepository<Playlist> playlists)
        {
            this.playlists = playlists;
        }

        public IQueryable<Playlist> GetAll()
        {
            return this.playlists.All();
        }

        public IQueryable<Playlist> GetTop(int count)
        {
            return this.playlists.All().OrderByDescending(x => x.Ratings.Sum(r => r.Value)).Take(count);
        }

        public Playlist GetById(int id)
        {
            return this.playlists.GetById(id);
        }

    }
}
