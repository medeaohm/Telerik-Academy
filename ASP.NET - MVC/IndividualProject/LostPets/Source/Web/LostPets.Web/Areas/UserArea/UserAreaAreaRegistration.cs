﻿namespace LostPets.Web.Areas.UserArea
{
    using System.Web.Mvc;

    public class UserAreaAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "UserArea";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "UserArea_default",
                "UserArea/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional });
        }
    }
}