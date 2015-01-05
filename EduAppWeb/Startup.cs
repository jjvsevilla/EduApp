using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EduAppWeb.Startup))]
namespace EduAppWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
