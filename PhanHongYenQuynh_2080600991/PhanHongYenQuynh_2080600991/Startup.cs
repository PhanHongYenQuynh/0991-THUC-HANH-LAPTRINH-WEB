using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PhanHongYenQuynh_2080600991.Startup))]
namespace PhanHongYenQuynh_2080600991
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
