﻿namespace MusicSystem.Models
{
    using System.Collections.Generic;

    public class Album
    {
        private ICollection<Artist> artists;
        private ICollection<Song> songs;

        public Album()
        {
            this.artists = new HashSet<Artist>();
            this.songs = new HashSet<Song>();
        }
        public int Id
        {
            get; set;
        }

        public string Title
        {
            get; set;
        }

        public ushort Year
        {
            get; set;
        }

        public string Producer
        {
            get; set;
        }

        public virtual ICollection<Artist> Artists
        {
            get
            {
                return this.artists;
            }
            set
            {
                this.artists = value;
            }
        }

        public virtual ICollection<Song> Song
        {
            get
            {
                return this.songs;
            }
            set
            {
                this.songs = value;
            }
        }
    }
}
