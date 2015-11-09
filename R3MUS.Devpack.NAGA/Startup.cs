using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(R3MUS.Devpack.NAGA.Startup))]
namespace R3MUS.Devpack.NAGA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
