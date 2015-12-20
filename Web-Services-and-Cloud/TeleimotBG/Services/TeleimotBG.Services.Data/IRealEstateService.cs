namespace TeleimotBG.Services.Data
{
    using System.Linq;

    using Models;

    public interface IRealEstateService
    {
        IQueryable<RealEstate> GetPublicRealEstates(int skip = 0, int take = 10);

        IQueryable<RealEstate>  GetPublicRealEstatesDetails(int id);

        RealEstate CreateRealEstateAd(
            string title, string description, string address, string contact, int constructionYear, int? sellingPrice, int? rentingPrice);
    }
}
