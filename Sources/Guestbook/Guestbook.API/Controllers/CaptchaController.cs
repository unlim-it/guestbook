namespace Guestbook.API.Controllers
{
    using System.Drawing.Imaging;
    using System.IO;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Web.Http;

    using Guestbook.API.Tools;

    public class CaptchaController : ApiController
    {
        public HttpResponseMessage Get()
        {
            using (var captchaGenerator = new CaptchaGenerator(368, 114))
            {
                var memoryStream = new MemoryStream();

                captchaGenerator.Image.Save(memoryStream, ImageFormat.Png);

                memoryStream.Position = 0;

                var response = Request.CreateResponse();
                response.Content = new StreamContent(memoryStream);
                response.Content.Headers.ContentType = new MediaTypeHeaderValue("image/png");
                response.Content.Headers.ContentLength = memoryStream.Length;

                response.SaveCaptcha(captchaGenerator.Text);
                return response;
            }
        }
    }
}
