using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASP_Midterm.Startup))]
namespace ASP_Midterm
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
