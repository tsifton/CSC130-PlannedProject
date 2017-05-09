using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PlannedWaterfall.Startup))]
namespace PlannedWaterfall
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
