using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebStuffLegal.Startup))]
namespace WebStuffLegal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
