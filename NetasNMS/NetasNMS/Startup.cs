using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NetasNMS.Startup))]
namespace NetasNMS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
