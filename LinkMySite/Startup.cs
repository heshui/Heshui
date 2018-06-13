using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LinkMySite.Startup))]
namespace LinkMySite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
