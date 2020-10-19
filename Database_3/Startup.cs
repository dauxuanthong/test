using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Database_3.Startup))]
namespace Database_3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
