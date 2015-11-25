using BullsAndCows.Services.Data;
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
using BullsAndCows.Web.Api.Models.Games;
using Microsoft.AspNet.Identity;

namespace BullsAndCows.Web.Api.Controllers
{
    public class GamesController : ApiController
    {
        private IGameService games;

        public GamesController(IGameService games)
        {
            this.games = games;
        }

        public IHttpActionResult Get(int page = 1)
        { 
            var userId = this.User.Identity.GetUserId();
            var games = this.games.GetPublicGames(page, userId).ProjectTo<ListedGameResponseModel>().ToList();

            return this.Ok(games);
        }
    }
}