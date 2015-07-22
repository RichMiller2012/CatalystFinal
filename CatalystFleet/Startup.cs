using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CatalystFleet.Startup))]
namespace CatalystFleet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}
