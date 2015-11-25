using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;
using System.Web.Http;
using Ninject.Web.Common.OwinHost;
using Ninject.Web.WebApi.OwinHost;

[assembly: OwinStartup(typeof(BullsAndCows.Web.Api.Startup))]

namespace BullsAndCows.Web.Api
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            AutoMapperConfig.RegisterMappings("BullsAndCows.Web.Api");
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
