using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Generator.Web.Startup))]
namespace Generator.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}