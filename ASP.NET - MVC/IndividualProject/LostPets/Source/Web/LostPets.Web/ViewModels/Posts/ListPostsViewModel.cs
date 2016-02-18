namespace LostPets.Web.ViewModels.Posts
{
    using System.Collections.Generic;
    using System.Linq;

    using AutoMapper;
    using Data.Models;
    using Infrastructure.Mapping;
    using Services.Web;
    using Data.Models.Types;
    using System;

    public class ListPostsViewModel : IMapFrom<Location>, IHaveCustomMappings
    {
        public int Id
        { get; set; }

        public City City
        { get; set; }

        public string Street
        { get; set; }

        public string AdditionalInfo
        { get; set; }

        public DateTime CreatedOn
        { get; set; }

        public DateTime? ModifiedOn
        { get; set; }

        public bool IsDeleted
        { get; set; }

        public DateTime? DeletedOn
        { get; set; }

        //public int Id { get; set;  }

        //public string Title { get; set; }

        //public string Content { get; set; }

        //public Photo Photo { get; set; }

        //public PostType PostType { get; set; }

        //public Pet Pet { get; set; }

        //public Location Location{ get; set; }

        //public string Url
        //{
        //    get
        //    {
        //        IIdentifierProvider identifier = new IdentifierProvider();
        //        return $"/Posts/Details/{identifier.EncodeId(this.Id)}";
        //    }
        //}

        public void CreateMappings(IMapperConfiguration configuration)
        {
            //configuration.CreateMap<PostViewModel, Location>()
            //    .ReverseMap();
            //configuration.CreateMap<Pet, PostViewModel>()
            //    .ReverseMap();
            //configuration.CreateMap<User, PostViewModel>()
            //    .ReverseMap();
            configuration.CreateMap<ListPostsViewModel, Location>().ReverseMap();
            configuration.CreateMap<Location, ListPostsViewModel>().ReverseMap();
            //.ForMember(x => x.Photo, opt => opt.MapFrom(x => x.Gallery.OrderBy(f => f.Id).FirstOrDefault()))
            //.ReverseMap();
        }
    }
}