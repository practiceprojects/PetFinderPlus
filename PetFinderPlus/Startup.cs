using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PetFinderPlus.Startup))]
namespace PetFinderPlus
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
