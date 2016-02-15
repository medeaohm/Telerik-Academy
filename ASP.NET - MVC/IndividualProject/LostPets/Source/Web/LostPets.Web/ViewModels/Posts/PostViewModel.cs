﻿namespace LostPets.Web.ViewModels.Posts
{
    using System.Collections.Generic;
    using System.Linq;

    using AutoMapper;
    using Data.Models;
    using Infrastructure.Mapping;
    using Services.Web;

    public class PostViewModel : IMapFrom<Post>, IHaveCustomMappings
    {
        public IEnumerable<PostViewModel> Posts { get; set; }

        public int Id { get; set;  }

        public string Title { get; set; }

        public string Content { get; set; }

        public int? ImageId { get; set; }

        public string PostType { get; set; }

        public string AnimalType { get; set; }

        public string Author { get; set; }

        public string PetName { get; set; }

        public string PetAge { get; set; }

        public string PetDescription { get; set; }

        public string LocationCity { get; set; }

        public string LocationStreet { get; set; }

        public string LocationAdditionalInfo { get; set; }

        public string Url
        {
            get
            {
                IIdentifierProvider identifier = new IdentifierProvider();
                return $"/Posts/Details/{identifier.EncodeId(this.Id)}";
            }
        }

        public void CreateMappings(IMapperConfiguration configuration)
        {
            configuration.CreateMap<Post, PostViewModel>()
                .ForMember(x => x.PostType, opt => opt.MapFrom(x => x.PostType.ToString()))
                .ForMember(x => x.AnimalType, opt => opt.MapFrom(x => x.AnimalType.ToString()))
                .ForMember(x => x.ImageId, opt => opt.MapFrom(x => x.Gallery.OrderBy(f => f.Id).FirstOrDefault().Id))
                .ForMember(x => x.Author, opt => opt.MapFrom(x => x.Author.UserName))
                .ForMember(x => x.PetName, opt => opt.MapFrom(x => x.Pet.Name))
                .ForMember(x => x.PetAge, opt => opt.MapFrom(x => x.Pet.Age.ToString()))
                .ForMember(x => x.PetDescription, opt => opt.MapFrom(x => x.Pet.Description))
                .ForMember(x => x.LocationCity, opt => opt.MapFrom(x => x.Location.City.ToString()))
                .ForMember(x => x.LocationStreet, opt => opt.MapFrom(x => x.Location.Street))
                .ForMember(x => x.LocationAdditionalInfo, opt => opt.MapFrom(x => x.Location.AdditionalInfo));
        }
    }
}