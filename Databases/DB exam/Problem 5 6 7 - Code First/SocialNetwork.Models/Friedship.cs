namespace SocialNetwork.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Friedship
    {
        public int Id
        {
            get; set;
        }

        [Required]
        [ForeignKey("Sender")]
        public string SenderId
        {
            get; set;
        }

        public virtual Profile Sender
        {
            get; set;
        }

        [Required]
        [ForeignKey("Receiver")]
        public string ReceiverId
        {
            get; set;
        }

        public virtual Profile Receiver
        {
            get; set;
        }

        public bool FriendshipApproved
        {
            get; set;
        }

        public DateTime? Date
        {
            get; set;
        }
    }
}
