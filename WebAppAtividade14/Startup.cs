using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppAtividade14.Startup))]
namespace WebAppAtividade14
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
