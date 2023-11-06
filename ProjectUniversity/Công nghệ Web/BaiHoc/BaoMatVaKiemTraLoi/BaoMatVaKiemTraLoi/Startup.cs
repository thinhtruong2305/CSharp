using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BaoMatVaKiemTraLoi.Startup))]
namespace BaoMatVaKiemTraLoi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
