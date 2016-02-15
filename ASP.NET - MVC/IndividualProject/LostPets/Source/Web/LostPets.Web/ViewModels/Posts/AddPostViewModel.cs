namespace LostPets.Web.ViewModels.Posts
{
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Web;

    using AutoMapper;
    using Data.Models;
    using Infrastructure.Mapping;

    public class AddPostViewModel : IMapFrom<Post>, IHaveCustomMappings
    {
        public int Id { get; set;  }

        public Pet Pet { get; set; }

        public Location Location { get; set; }

        [UIHint("SingleLineText")]
        public string Title { get; set; }

        [UIHint("MultiLineText")]
        public string Content { get; set; }

        [Display(Name = "Post Type")]
        public string PostType { get; set; }

        [Display(Name = "Animal Type")]
        public string AnimalType { get; set; }

        public string Author { get; set; }

        [UIHint("SingleLineText")]
        [Display(Name = "Pet Name")]
        public string PetName { get; set; }

        [UIHint("Integer")]
        [Display(Name ="Pet Age")]
        public string PetAge { get; set; }

        [UIHint("MultiLineText")]
        [Display(Name = "Pet Description")]
        public string PetDescription { get; set; }

        [Display(Name = "City")]
        public string LocationCity { get; set; }

        [UIHint("SingleLineText")]
        [Display(Name = "Street")]
        public string LocationStreet { get; set; }

        [UIHint("MultiLineText")]
        [Display(Name = "Additional Information")]
        public string LocationAdditionalInfo { get; set; }

        public HttpPostedFileBase UploadedImage { get; set; }

        public void CreateMappings(IMapperConfiguration configuration)
        {
            configuration.CreateMap<Post, PostViewModel>()
                .ForMember(x => x.PostType, opt => opt.MapFrom(x => x.PostType.ToString()))
                .ForMember(x => x.AnimalType, opt => opt.MapFrom(x => x.AnimalType.ToString()))
                .ForMember(x => x.Author, opt => opt.MapFrom(x => x.Author.UserName))
                .ForMember(x => x.PetName, opt => opt.MapFrom(x => x.Pet.Name))
                .ForMember(x => x.PetAge, opt => opt.MapFrom(x => x.Pet.Age))
                .ForMember(x => x.PetDescription, opt => opt.MapFrom(x => x.Pet.Description))
                .ForMember(x => x.LocationCity, opt => opt.MapFrom(x => x.Location.City.ToString()))
                .ForMember(x => x.LocationStreet, opt => opt.MapFrom(x => x.Location.Street))
                .ForMember(x => x.LocationAdditionalInfo, opt => opt.MapFrom(x => x.Location.AdditionalInfo))
                .ReverseMap();
        }
    }
}