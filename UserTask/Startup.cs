using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UserTask.Startup))]
namespace UserTask
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
