using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;
using YoutubePlaylists.Data;

namespace YouTubePlaylists.Web
{
    public partial class PlaylistDetails : System.Web.UI.Page
    {
        public YouTubePlaylistsDbContext dbContext;

        public PlaylistDetails()
        {
            this.dbContext = new YouTubePlaylistsDbContext();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // The id parameter should match the DataKeyNames value set on the control
        // or be decorated with a value provider attribute, e.g. [QueryString]int id
        public YouTubePlaylists.Data.Models.Playlist FormViewPlylistDetails_GetItem([QueryString("id")]int? playlistID)
        {
            if (playlistID == null)
            {
                Response.Redirect("~/");
            }

            var playlist = this.dbContext.Playlists.FirstOrDefault(b => b.Id == playlistID);
            return playlist;
        }

        // The return type can be changed to IEnumerable, however to support
        // paging and sorting, the following parameters must be added:
        //     int maximumRows
        //     int startRowIndex
        //     out int totalRowCount
        //     string sortByExpression
        public IQueryable<YouTubePlaylists.Data.Models.Video> test_GetData([QueryString("id")]int? id)
        {
            var videos = this.dbContext.Videos.Where(b => b.PlaylistId == id).OrderBy(b => b.Id);
            return videos;
        }
    }
}