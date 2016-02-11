namespace YouTubePlaylists.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Video
    {
        public int Id
        {
            get; set;
        }

        [Required]
        public string Url
        {
            get; set;
        }

        [Required]
        public int PlaylistId
        {
            get; set;
        }

        [ForeignKey("PlaylistId")]
        public virtual Playlist Playlist
        {
            get; set;
        }
    }
}