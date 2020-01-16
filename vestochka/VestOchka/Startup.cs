using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VestOchka.Startup))]
namespace VestOchka
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
