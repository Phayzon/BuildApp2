using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BuildApp3.Startup))]
namespace BuildApp3
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
