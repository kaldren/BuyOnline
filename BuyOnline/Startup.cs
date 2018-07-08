using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BuyOnline.Startup))]
namespace BuyOnline
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
