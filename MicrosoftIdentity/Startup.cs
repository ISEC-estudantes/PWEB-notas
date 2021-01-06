using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MicrosoftIdentity.Startup))]
namespace MicrosoftIdentity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
