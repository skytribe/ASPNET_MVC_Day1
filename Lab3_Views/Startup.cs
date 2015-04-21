using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab3_Views.Startup))]
namespace Lab3_Views
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
