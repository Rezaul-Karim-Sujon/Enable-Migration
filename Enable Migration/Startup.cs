using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Enable_Migration.Startup))]
namespace Enable_Migration
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
