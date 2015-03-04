using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TEX.Web.Startup))]
namespace TEX.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
