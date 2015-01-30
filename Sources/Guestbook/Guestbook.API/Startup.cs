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
            config.MapHttpAttributeRoutes();
            config.Routes.MapHttpRoute("def", "api/{Controller}");
            config.Formatters.Remove(config.Formatters.XmlFormatter);

            app.UseWebApi(config);
        }
    }
}