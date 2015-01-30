namespace Guestbook.Silverlight.Network
{
    using System.Threading.Tasks;

    using Guestbook.Models;

    public class GuestbookService
    {
        private readonly string serviceUrl;

        public GuestbookService()
        {
            serviceUrl = "http://localhost:3090/api";
        }

        public async Task<MessageSearchResult> SearchMessages(MessageFilter filter)
        {
            var messages = await WebInvoker.Invoke<MessageSearchResult>(string.Format("{0}/search/messages", this.serviceUrl), "POST", filter, null);
            return messages;
        }
    }
}
