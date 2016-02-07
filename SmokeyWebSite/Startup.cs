using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SmokeyWebSite.Startup))]
namespace SmokeyWebSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
