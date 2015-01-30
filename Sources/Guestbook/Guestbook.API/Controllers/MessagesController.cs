namespace Guestbook.API.Controllers
{
    using System.Collections.Generic;
    using System.Web.Http;

    using Guestbook.Models;

    public class MessagesController : ApiController
    {
        public IEnumerable<Message> Get()
        {
            var messages = new List<Message>
            {
                new Message { Email = "test12345@gmail.com" },
                new Message { Email = "test12345@gmail.com" },
                new Message { Email = "test12345@gmail.com" },
                new Message { Email = "test12345@gmail.com" },
                new Message { Email = "test12345@gmail.com" },
                new Message { Email = "test12345@gmail.com" },
                new Message { Email = "test12345@gmail.com" },
                new Message { Email = "test12345@gmail.com" },
                new Message { Email = "test12345@gmail.com" },
                new Message { Email = "test12345@gmail.com" },
                new Message { Email = "test12345@gmail.com" },
            };

            return messages;
        }
    }
}
