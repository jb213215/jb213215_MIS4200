using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(jb213215_MIS4200.Startup))]
namespace jb213215_MIS4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
