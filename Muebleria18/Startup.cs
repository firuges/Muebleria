using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Muebleria18.Startup))]
namespace Muebleria18
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
