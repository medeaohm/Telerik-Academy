namespace TicketingSystem.Web.Controllers
{
    using AutoMapper.QueryableExtensions;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using TicketingSystem.Data;
    using Infrastructure.Mapping.Services.Contracts;
    using ViewModels.Home;

    public class HomeController : BaseController
    {
        private IHomeService homeService;

        public HomeController(ITicketSystemData data, IHomeService homeService)
            : base(data)
        {
            this.homeService = homeService;
        }

        public ActionResult Index()
        {               
            return View();
        }

        public ActionResult Error()
        {
            return View();
        }

        [ChildActionOnly]
        [OutputCache(Duration = 60 * 60)]
        public ActionResult MostCommentedTickets()
        {
            return PartialView("_MostCommentedTicketsPartial", this.homeService.GetIndexViewModel(6));
        }
    }
}