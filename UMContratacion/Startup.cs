using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UMContratacion.Startup))]
namespace UMContratacion
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
