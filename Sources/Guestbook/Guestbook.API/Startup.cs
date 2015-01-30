[assembly: Microsoft.Owin.OwinStartup(typeof(Guestbook.API.Startup))]
namespace Guestbook.API
{
    using System.Web.Http;
    using Owin;
    
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();
            config.Routes.MapHttpRoute("Default", "api/{controller}/{id}", new { id = RouteParameter.Optional });
            app.UseWebApi(config);
        }
    }
}