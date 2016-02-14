namespace LostPets.Web.Controllers
{
    using System;
    using System.Linq;
    using System.Web.Mvc;
    using System.Web.Routing;

    using AutoMapper;

    using Data.Models;
    using Infrastructure.Mapping;
    using Services.Data;
    using Services.Web;

    public abstract class BaseController : Controller
    {
        protected IUserService users;

        public BaseController(IUserService users)
        {
            this.users = users;
        }

        protected IMapper Mapper
        {
            get
            {
                return AutoMapperConfig.Configuration.CreateMapper();
            }
        }

        public ICacheService Cache { get; set; }

        protected User CurrentUser { get; private set; }

        protected override IAsyncResult BeginExecute(RequestContext requestContext, AsyncCallback callback, object state)
        {
            this.CurrentUser = this.users
                .All()
                .FirstOrDefault(u => u.UserName == requestContext.HttpContext.User.Identity.Name);

            return base.BeginExecute(requestContext, callback, state);
        }
    }
}
