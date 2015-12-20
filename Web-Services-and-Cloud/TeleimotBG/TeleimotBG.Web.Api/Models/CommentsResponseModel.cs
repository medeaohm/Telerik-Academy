using AutoMapper;
using System;
using TeleimotBG.Models;

namespace TeleimotBG.Web.Api.Models
{
    public class CommentsResponseModel
    {
        public string Content
        {
            get; set;
        }

        public string Username
        {
            get; set;
        }

        public DateTime CreatedOn
        {
            get; set; 
        }

        public void CreateMappings(IConfiguration configuration)
        {
            configuration.CreateMap<Comment, CommentsResponseModel>()
                .ForMember(c => c.Username, opts => opts.MapFrom(c => c.User.UserName));
        }
    }
}