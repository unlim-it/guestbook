namespace Guestbook.Silverlight.Network
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Guestbook.Models;

    public class GuestbookService
    {
        private readonly string serviceUrl;

        public GuestbookService()
        {
            serviceUrl = "http://localhost:3090/api";
        }

        public async Task<IEnumerable<Message>> GetMessages()
        {
            var messages = await WebInvoker.Invoke<IEnumerable<Message>>(string.Format("{0}/messages", this.serviceUrl), "GET", null, null);
            return messages;
        }
    }
}
