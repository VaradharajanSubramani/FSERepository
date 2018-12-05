using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ass23_WCF.Startup))]
namespace Ass23_WCF
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
