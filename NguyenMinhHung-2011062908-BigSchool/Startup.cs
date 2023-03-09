using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NguyenMinhHung_2011062908_BigSchool.Startup))]
namespace NguyenMinhHung_2011062908_BigSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
