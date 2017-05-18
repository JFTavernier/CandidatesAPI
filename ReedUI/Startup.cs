using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ReedUI.Startup))]
namespace ReedUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
