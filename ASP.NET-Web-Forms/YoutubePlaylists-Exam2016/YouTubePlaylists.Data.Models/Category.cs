﻿namespace YouTubePlaylists.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Category
    {
        public int Id
        {
            get; set;
        }

        [Required]
        [Index(IsUnique = true)]
        [MaxLength(100)]
        public string Name
        {
            get; set;
        }
    }
}
