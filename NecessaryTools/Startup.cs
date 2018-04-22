using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NecessaryTools.Startup))]
namespace NecessaryTools
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
