namespace TeleimotBG.Web.Api.Controllers
{
    using Microsoft.AspNet.Identity;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Http;

    using AutoMapper;
    using AutoMapper.Configuration;
    using AutoMapper.Mappers;
    using AutoMapper.Internal;
    using AutoMapper.QueryableExtensions;


    using Services.Data;
    using Models;

    public class RealEstatesController : ApiController
    {
        private readonly IRealEstateService realEstates;

        public RealEstatesController(IRealEstateService realEstates)
        {
            this.realEstates = realEstates;
        }

        public IHttpActionResult Get(string skip = "0", string take = "10")
        {
            int skipAsNumber;
            int takeAsNumber;

            if (!int.TryParse(skip, out skipAsNumber))
            {
                skipAsNumber = 0;
            }

            if (!int.TryParse(take, out takeAsNumber))
            {
                skipAsNumber = 10;
            }

            var userId = this.User.Identity.GetUserId();
            var games = this.realEstates
                .GetPublicRealEstates(skipAsNumber, takeAsNumber)
                .ProjectTo<ListedRealEstatesModel>()
                .ToList();

            return this.Ok(realEstates);
        }

        public IHttpActionResult Get(int id)
        {
            var realEstateResult = this.realEstates
                .GetPublicRealEstatesDetails(id)
                .FirstOrDefault();

            return this.Ok(realEstateResult);
        }


        [Authorize]
        public IHttpActionResult GetPrivate(int id)
        {
            var realEstateResult = this.realEstates
                .GetPublicRealEstatesDetails(id)
                .FirstOrDefault();

            return this.Ok(realEstateResult);
        }

        [Authorize]
        public IHttpActionResult Post(CreateRealEstatesModel model)
        {
            var newRealEstate = this.realEstates.CreateRealEstateAd(
                model.Title,
                model.Description,
                model.Address,
                model.Contact, 
                model.ConstructionYear,
                model.SellingPrice,
                model.RentingPrice            
                );

            var realEstateResult = realEstates
                .GetPublicRealEstates()
                .ProjectTo<ListedRealEstatesModel>()
                .FirstOrDefault();


            return this.Created(
                string.Format("/api/RealEstates/{0}", newRealEstate),
                realEstateResult);
        }
    }
}