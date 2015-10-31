namespace SocialNetwork.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class ChatMessage
    {
        public int Id
        {
            get; set;
        }

        public int FiendshipId
        {
            get; set;
        }

        public string ProfileId
        {
            get; set;
        }

        [Required]
        public string Content
        {
            get; set;
        }

        public DateTime DateSending
        {
            get; set;
        }

        public DateTime DateSeeing
        {
            get; set;
        }
    }
}
