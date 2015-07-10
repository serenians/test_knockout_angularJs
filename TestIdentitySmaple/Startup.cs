using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestIdentitySmaple.Startup))]
namespace TestIdentitySmaple
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
