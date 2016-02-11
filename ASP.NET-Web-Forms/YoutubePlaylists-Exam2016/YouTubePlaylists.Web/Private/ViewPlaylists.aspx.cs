using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;
using YoutubePlaylists.Data;

namespace YouTubePlaylists.Web.Private
{
    public partial class ViewPlaylists : System.Web.UI.Page
    {
        public YouTubePlaylistsDbContext dbContext;

        public ViewPlaylists()
        {
            this.dbContext = new YouTubePlaylistsDbContext();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // The return type can be changed to IEnumerable, however to support
        // paging and sorting, the following parameters must be added:
        //     int maximumRows
        //     int startRowIndex
        //     out int totalRowCount
        //     string sortByExpression

        public IQueryable<YouTubePlaylists.Data.Models.Playlist> gvPlaylist_GetData()
        {
            return this.dbContext.Playlists.OrderBy(b => b.Id);
        }

        // The return type can be changed to IEnumerable, however to support
        // paging and sorting, the following parameters must be added:
        //     int maximumRows
        //     int startRowIndex
        //     out int totalRowCount
        //     string sortByExpression
        public IQueryable<YouTubePlaylists.Data.Models.Playlist> lvPlaylists_GetData([QueryString]string orderBy)
        {
            var playlists = this.dbContext.Playlists;
            //var result = this.ArticlesServices.GetAll();

            // TODO: validate orderBy or create dictionary

            if (string.IsNullOrEmpty(orderBy))
            {
                playlists.OrderBy(x => x.Id);
            }
            else
            {
                playlists.OrderBy(orderBy + " Ascending");
            }
            return playlists;
        }
    }
}