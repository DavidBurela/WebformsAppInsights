using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebformsAppInsights.Startup))]
namespace WebformsAppInsights
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
