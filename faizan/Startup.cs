using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(faizan.Startup))]
namespace faizan
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
