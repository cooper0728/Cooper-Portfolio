using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Cooper_Portfolio.Startup))]
namespace Cooper_Portfolio
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
