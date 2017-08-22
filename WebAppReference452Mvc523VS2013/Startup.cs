using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppReference452Mvc523VS2013.Startup))]
namespace WebAppReference452Mvc523VS2013
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
