using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FutureAcademy1.Startup))]
namespace FutureAcademy1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
