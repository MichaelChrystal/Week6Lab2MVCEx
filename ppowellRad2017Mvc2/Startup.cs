using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ppowellRad2017Mvc2.Startup))]
namespace ppowellRad2017Mvc2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
