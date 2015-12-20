namespace TeleimotBG.Web.Api.Models
{
    using AutoMapper;
    using System;
    using System.Collections.Generic;
    using TeleimotBG.Models;
    using TeleimotBG.Web.Api.Infrastructure.Mapping;

    public class PrivateRealEstatesDetailsResponseModel : IMapFrom<RealEstate>, IHaveCustomMappings
    {
        public string Contacts
        {
            get; set;
        }

        public IEnumerable<CommentsResponseModel> Comments
        {
            get; set;
        }

        public DateTime CreatedOn
        {
            get; set;
        }

        public int ConstructionYear
        {
            get; set;
        }

        public string Address
        {
            get; set;
        }

        public RealEstateType RealEstateType
        {
            get; set;
        }

        public string Description
        {
            get; set;
        }

        public int Id
        {
            get; set;
        }

        public string Title
        {
            get; set;
        }

        public int? SellingPrice
        {
            get; set;
        }

        public int? RentingPrice
        {
            get; set;
        }

        public bool CanBeSold
        {
            get; set;
        }

        public bool CanBeRented
        {
            get; set;
        }

        public void CreateMappings(IConfiguration configuration)
        {
            configuration.CreateMap<RealEstate, RealEstatesDetailsResponseModel>()
                .ForMember(r => r.RealEstateType, opts => opts.MapFrom(r => r.RealEstateType.ToString()))
                .ForMember(r => r.CanBeSold, opts => opts.MapFrom(r => r.SellingPrice == null ? false : true))
                .ForMember(r => r.CanBeRented, opts => opts.MapFrom(r => r.RentingPrice == null ? false : true));
        }
    }
}