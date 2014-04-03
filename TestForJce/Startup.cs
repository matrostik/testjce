using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestForJce.Startup))]
namespace TestForJce
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
