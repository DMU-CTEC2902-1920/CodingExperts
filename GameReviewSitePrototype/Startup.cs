using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GameReviewSitePrototype.Startup))]
namespace GameReviewSitePrototype
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
