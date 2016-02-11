namespace TicketingSystem.Web.ViewModels.Comments
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using AutoMapper;
    using TicketSystem.Web.Infrastructure.Mapping;
    using Models;

    public class PostCommentViewModel : IMapFrom<Comment>
    {
        public PostCommentViewModel()
        {

        }

        public PostCommentViewModel(int ticketId)
        {
            this.TicketId = ticketId;
        }

        public int TicketId
        {
            get; set;
        }

        [Required]
        [StringLength(1000, MinimumLength = 100)]
        [UIHint("MultiLineText")]
        public string Content
        {
            get; set;
        }
    }
}