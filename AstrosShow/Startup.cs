using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AstrosShow.Startup))]
namespace AstrosShow
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
