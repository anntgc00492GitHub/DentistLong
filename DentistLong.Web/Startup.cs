using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DentistLong.Web.Startup))]
namespace DentistLong.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
