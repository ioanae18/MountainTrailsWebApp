using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MountainTrailsWebApp.Startup))]
namespace MountainTrailsWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
