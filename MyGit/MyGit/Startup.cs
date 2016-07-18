using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyGit.Startup))]
namespace MyGit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
