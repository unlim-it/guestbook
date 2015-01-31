namespace Guestbook.API.Controllers
{
    using System.Net;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System.Web;
    using System.Web.Http;

    using Guestbook.API.Tools;
    using Guestbook.Data;
    using Guestbook.Models;

    public class MessagesController : ApiController
    {
        [HttpPost]
        public async Task<HttpResponseMessage> Post(PostData<Message> data)
        {
            if (!this.Request.ValidateCaptcha(data.CaptchaCode))
            {
                return new HttpResponseMessage { StatusCode = HttpStatusCode.Unauthorized };
            }

            var message = data.Data;

            var messageManager = new MessagesManager();
            message.IPAddress = HttpContext.Current.Request.UserHostAddress;
            message.WebBrowser = HttpContext.Current.Request.UserAgent;

            await messageManager.InsertMessage(message);

            return new HttpResponseMessage { StatusCode = HttpStatusCode.OK };
        }

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
