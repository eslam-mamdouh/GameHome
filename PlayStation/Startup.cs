using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PlayStation.Startup))]
namespace PlayStation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
