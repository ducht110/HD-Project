using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HDMvcWebsite.Startup))]
namespace HDMvcWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
