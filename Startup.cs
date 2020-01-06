using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DreamStream.Startup))]
namespace DreamStream
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
