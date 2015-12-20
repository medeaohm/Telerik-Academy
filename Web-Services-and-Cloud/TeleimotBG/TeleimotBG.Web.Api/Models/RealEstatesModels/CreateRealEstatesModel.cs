namespace TeleimotBG.Web.Api.Models
{
    using AutoMapper;
    using TeleimotBG.Models;
    using TeleimotBG.Web.Api.Infrastructure.Mapping;

    public class CreateRealEstatesModel : IMapFrom<RealEstate>, IHaveCustomMappings
    {
        public int Id
        {
            get; set;
        }

        public string Title
        {
            get; set;
        }

        public string Description
        {
            get; set;
        }

        public string Address
        {
            get; set;
        }

        public string Contact
        {
            get; set;
        }

        public int ConstructionYear
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
            configuration.CreateMap<RealEstate, ListedRealEstatesModel>()
                .ForMember(r => r.CanBeSold, opts => opts.MapFrom(r => r.SellingPrice == null ? false : true))
                .ForMember(r => r.CanBeRented, opts => opts.MapFrom(r => r.RentingPrice == null ? false : true));
        }
    }
}