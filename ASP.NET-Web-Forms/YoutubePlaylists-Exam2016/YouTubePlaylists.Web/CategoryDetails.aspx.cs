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
    public partial class CategoryDetails : System.Web.UI.Page
    {
        public YouTubePlaylistsDbContext dbContext;

        public CategoryDetails()
        {
            this.dbContext = new YouTubePlaylistsDbContext();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // The id parameter should match the DataKeyNames value set on the control
        // or be decorated with a value provider attribute, e.g. [QueryString]int id
        public YouTubePlaylists.Data.Models.Category FormViewPlylistDetails_GetItem([QueryString("id")]int? CategoryId)
        {
            if (CategoryId == null)
            {
                Response.Redirect("~/");
            }

            var category = this.dbContext.Categories.FirstOrDefault(b => b.Id == CategoryId);
            return category;
        }

        public IQueryable<YouTubePlaylists.Data.Models.Playlist> test_GetData([QueryString("id")]int? id)
        {
            var playlists = this.dbContext.Playlists.Where(b => b.CategoryId == id).OrderBy(b => b.Id);
            return playlists;
        }
    }
}