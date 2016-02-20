﻿namespace LostPets.Web.ViewModels.Posts
{
    using System.Collections.Generic;
    using System.Linq;

    using AutoMapper;
    using Data.Models;
    using Infrastructure.Mapping;
    using Services.Web;
    using Data.Models.Types;
    using Comments;

    public class PostViewModel : IMapFrom<Post>, IHaveCustomMappings
    {
        //public IEnumerable<PostViewModel> Posts { get; set; }

        public int Id { get; set;  }

        public string Title { get; set; }

        public string Content { get; set; }

        public Photo Photo { get; set; }

        public PostType PostType { get; set; }

        public Pet Pet { get; set; }

        public User Author { get; set; }

        public Location Location { get; set; }

        public ICollection<CommentViewModel> Comments
        {
            get; set;
        }

        public string Url
        {
            get
            {
                IIdentifierProvider identifier = new IdentifierProvider();
                return $"/Posts/Details/{identifier.EncodeId(this.Id)}";
            }
        }

        public string UserUrl
        {
            get
            {
                return $"/Profile/ViewUserProfile/{this.Author.Id}";
            }
        }

        public void CreateMappings(IMapperConfiguration configuration)
        {
            configuration.CreateMap<PostViewModel, Location>()
                .ReverseMap();
            configuration.CreateMap<Pet, PostViewModel>()
                .ReverseMap();
            configuration.CreateMap<User, PostViewModel>()
                .ReverseMap();
            configuration.CreateMap<Post, PostViewModel>()
                .ForMember(x => x.Photo, opt => opt.MapFrom(x => x.Gallery.OrderBy(f => f.Id).FirstOrDefault()))
                .ReverseMap();
        }
    }
}