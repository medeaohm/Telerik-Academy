namespace TeleimotBG.Services.Data
{
    using System;
    using System.Linq;

    using Models;
    using TeleimotBG.Data.Repositories;

    public class RealEstateService : IRealEstateService
    {
        private IRepository<RealEstate> realEstates;

        public RealEstateService(IRepository<RealEstate> realEstates)
        {
            this.realEstates = realEstates;
        }

        public IQueryable<RealEstate> GetPublicRealEstates(int skip = 0, int take = 10)
        {
            return this.realEstates
                 .All()
                 .OrderByDescending(re => re.CreatedOn.TimeOfDay)
                 .Skip((skip) * take)
                 .Take(take);
        }

        public IQueryable<RealEstate> GetPublicRealEstatesDetails(int id)
        {
            return this.realEstates
                .All()
                .Where(r => r.RealEstateId == id);
        }

        public RealEstate CreateRealEstateAd(
            string title, string description, string address, string contact, int constructionYear, int? sellingPrice, int? rentingPrice)
        {
            var newRealEstate = new RealEstate
            {
                Title = title,
                Description = description,
                Contact = contact,
                YearOfContruction = constructionYear,
                SellingPrice = sellingPrice,
                RentingPrice = rentingPrice,
                CreatedOn = DateTime.UtcNow
            };

            this.realEstates.Add(newRealEstate);
            this.realEstates.SaveChanges();

            return newRealEstate;
        }
    }
}
