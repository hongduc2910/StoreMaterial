using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StoreMaterial.Startup))]
namespace StoreMaterial
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
