namespace SocialNetwork.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Image
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
        [MaxLength(4)]
        public string Extension
        {
            get; set;
        }
    }
}
