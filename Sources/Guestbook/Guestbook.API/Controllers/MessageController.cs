namespace Guestbook.API.Controllers
{
    using System.Web.Http;

    using Guestbook.Models;

    public class MessageController : ApiController
    {
        public Message Get()
        {
            return new Message { Email = "kurilenkodenis@gmail.com" };
        }
    }
}
