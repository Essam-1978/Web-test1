using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(web_deploy_1.Startup))]
namespace web_deploy_1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
