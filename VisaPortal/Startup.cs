using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VisaPortal.Startup))]
namespace VisaPortal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
