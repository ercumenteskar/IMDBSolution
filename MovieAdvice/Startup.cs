using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MovieAdvice.Startup))]
namespace MovieAdvice
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
