using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TextBox_Control.Startup))]
namespace TextBox_Control
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
