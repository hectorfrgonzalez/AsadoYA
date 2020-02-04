using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AsadoYa.Backend.Startup))]
namespace AsadoYa.Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
