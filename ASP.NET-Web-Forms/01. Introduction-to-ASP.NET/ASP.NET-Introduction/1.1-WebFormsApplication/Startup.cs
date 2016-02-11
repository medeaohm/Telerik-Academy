using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_1._1_WebFormsApplication.Startup))]
namespace _1._1_WebFormsApplication
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
