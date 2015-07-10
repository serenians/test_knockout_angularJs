using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestAngularJsSample.Startup))]
namespace TestAngularJsSample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
