using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CARLOS.Startup))]
namespace CARLOS
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
