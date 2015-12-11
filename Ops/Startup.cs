using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ops.Startup))]
namespace Ops
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
