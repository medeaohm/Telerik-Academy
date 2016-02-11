namespace YouTubePlaylists.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Playlist
    {
        private ICollection<Video> videos;
        private ICollection<Rating> ratings;

        public Playlist()
        {
           this.videos = new HashSet<Video>();
           this.ratings = new HashSet<Rating>();
        }

        public int Id
        {
            get; set;
        }

        [Required]
        public string Title
        {
            get; set;
        }

        [Required]
        public string Description
        {
            get; set;
        }

        [Required]
        public int CategoryId
        {
            get; set;
        }

        [ForeignKey("CategoryId")]
        public virtual Category Category
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

        public DateTime DateCreated
        {
            get; set;
        }

        public virtual ICollection<Video> Videos
        {
            get
            {
                return this.videos;
            }
            set
            {
                this.videos = value;
            }
        }

        public virtual ICollection<Rating> Ratings
        {
            get
            {
                return this.ratings;
            }
            set
            {
                this.ratings = value;
            }
        }
    }
}
