[assembly: Microsoft.Owin.OwinStartup(typeof(Guestbook.API.Startup))]
namespace Guestbook.API
{
    using System.Web.Http;

    using Guestbook.Data.Migrations;
    using Owin;
    
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Create and apply all migrations if database not exists.
            Database.Initialize();

            var config = new HttpConfiguration();
            config.Routes.MapHttpRoute("Default", "api/{controller}/{id}", new { id = RouteParameter.Optional });
            app.UseWebApi(config);
        }
    }
}