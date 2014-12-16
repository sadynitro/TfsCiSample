using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SampleApp01.Startup))]
namespace SampleApp01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
