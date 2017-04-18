using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShopFruist.Startup))]
namespace ShopFruist
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
