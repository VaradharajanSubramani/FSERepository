using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ass13APIClient.Startup))]
namespace Ass13APIClient
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
