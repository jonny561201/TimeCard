using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TimeCardWeb.Startup))]
namespace TimeCardWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
