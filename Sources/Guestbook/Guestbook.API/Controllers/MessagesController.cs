namespace Guestbook.API.Controllers
{
    using System.Threading.Tasks;
    using System.Web.Http;

    using Guestbook.Data;
    using Guestbook.Models;

    public class MessagesController : ApiController
    {
        [HttpPost]
        [Route("api/search/messages")]
        public async Task<MessageSearchResult> Search(MessageFilter filter)
        {
            var messageManager = new MessagesManager();
            var result = await messageManager.SearchMessages(filter);
            return result;
        }
    }
}
