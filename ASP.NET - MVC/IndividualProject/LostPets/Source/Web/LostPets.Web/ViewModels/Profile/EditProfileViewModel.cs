﻿namespace LostPets.Web.ViewModels.Profile
{
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Web;

    using AutoMapper;

    using Data.Models;
    using Data.Models.Types;
    using Infrastructure.Mapping;

    public class EditProfileViewModel : IMapFrom<User>, IHaveCustomMappings
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        [UIHint("RegisterSingleLineText")]
        public string Email { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 4)]
        [Display(Name = "Username")]
        [UIHint("RegisterSingleLineText")]
        public string UserName { get; set; }

        [StringLength(30)]
        [Display(Name = "First name")]
        [UIHint("RegisterSingleLineText")]
        public string FirstName { get; set; }

        [StringLength(30)]
        [Display(Name = "Last name")]
        [UIHint("RegisterSingleLineText")]
        public string LastName { get; set; }

        [Display(Name = "Gender")]
        [DefaultValue(Gender.NotGiven)]
        public Gender Gender { get; set; }

        [Display(Name = "City")]
        [DefaultValue(City.NotGiven)]
        public City City { get; set; }

        [RegularExpression(@"^\d{10}$", ErrorMessage = "The phone number must be exactly 10 digits. ")]
        [Display(Name = "Phone Number")]
        [UIHint("RegisterSingleLineText")]
        public string PhoneNumber { get; set; }

        [StringLength(200)]
        [Display(Name = "Facebook Profile")]
        [UIHint("RegisterSingleLineText")]
        public string FacebookProfile { get; set; }

        public int? ProfilePictureId { get; set; }

        public HttpPostedFileBase UploadedImage { get; set; }

        public void CreateMappings(IMapperConfiguration configuration)
        {
            configuration.CreateMap<User, ProfileViewModel>()
                .ForMember(x => x.ProfilePictureId, opt => opt.MapFrom(x => x.ProfilePictureId));
        }
    }
}
