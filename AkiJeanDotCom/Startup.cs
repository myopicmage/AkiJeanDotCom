using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AkiJeanDotCom.Startup))]
namespace AkiJeanDotCom
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
