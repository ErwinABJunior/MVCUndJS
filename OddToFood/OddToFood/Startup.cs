using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OddToFood.Startup))]
namespace OddToFood
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
