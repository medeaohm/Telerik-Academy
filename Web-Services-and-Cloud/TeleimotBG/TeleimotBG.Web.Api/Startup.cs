using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;
using TeleimotBG.Web.Api.App_Start;
using System.Web.Http;
using Ninject.Web.Common.OwinHost;
using Ninject.Web.WebApi.OwinHost;

[assembly: OwinStartup(typeof(TeleimotBG.Web.Api.Startup))]

namespace TeleimotBG.Web.Api
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            AutoMapperConfig.RegisterMappings("TeleimotBG.Web.Api");
            ConfigureAuth(app);

            var httpConfig = new HttpConfiguration();

            WebApiConfig.Register(httpConfig);

            httpConfig.EnsureInitialized();

            app
                .UseNinjectMiddleware(NinjectConfig.CreateKernel)
                .UseNinjectWebApi(httpConfig);
        }
    }
}
