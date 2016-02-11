using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LostPets.Web.Startup))]
namespace LostPets.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
