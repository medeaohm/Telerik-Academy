using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using YoutubePlaylists.Data;
using YouTubePlaylists.Data.Services.Contracts;

namespace YouTubePlaylists.Web
{
    public partial class _Default : Page
    {
        public YouTubePlaylistsDbContext dbContext;

        public _Default()
        {
            this.dbContext = new YouTubePlaylistsDbContext();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IEnumerable<Data.Models.Playlist> repeaterPlaylists_GetData()
        {
            return this.dbContext.Playlists.OrderByDescending(x => x.Ratings.Sum(r => r.Value)).Take(10);

        }
    }
}