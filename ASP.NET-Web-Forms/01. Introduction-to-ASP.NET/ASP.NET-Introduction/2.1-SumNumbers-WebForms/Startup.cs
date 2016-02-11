using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_2._1_SumNumbers_WebForms.Startup))]
namespace _2._1_SumNumbers_WebForms
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
