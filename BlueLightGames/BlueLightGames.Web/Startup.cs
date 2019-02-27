using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BlueLightGames.Web.Startup))]
namespace BlueLightGames.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
