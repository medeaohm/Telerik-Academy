using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubePlaylists.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Rating
    {
        public int Id
        {
            get; set;
        }

        [Range(1, 5)]
        public int Value
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

        [Required]
        public string AuthorId
        {
            get; set;
        }

        [ForeignKey("AuthorId")]
        public virtual User Author
        {
            get; set;
        }

    }
}
