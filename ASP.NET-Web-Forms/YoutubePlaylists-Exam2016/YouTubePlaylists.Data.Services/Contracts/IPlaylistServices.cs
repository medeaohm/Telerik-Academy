namespace YouTubePlaylists.Data.Services.Contracts
{
    using System.Linq;
    using YouTubePlaylists.Data.Models;

    public interface IPlaylistServices
    {
        IQueryable<Playlist> GetTop(int count);

        IQueryable<Playlist> GetAll();

        Playlist GetById(int id);
/*

        void UpdateById(int id, Playlist updatePlaylist);

        void DeleteById(int id);

        void Create(Playlist playlist);
   */
    }
}
