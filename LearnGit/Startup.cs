using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LearnGit.Startup))]
namespace LearnGit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
