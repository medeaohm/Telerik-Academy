using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_1._2_MVC_Application.Startup))]
namespace _1._2_MVC_Application
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
