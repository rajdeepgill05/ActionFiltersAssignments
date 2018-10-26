using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ActionFiltersAssignment.Startup))]
namespace ActionFiltersAssignment
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
