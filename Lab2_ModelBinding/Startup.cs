using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab2_ModelBinding.Startup))]
namespace Lab2_ModelBinding
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
