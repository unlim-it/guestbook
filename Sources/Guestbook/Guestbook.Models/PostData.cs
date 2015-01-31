namespace Guestbook.Models
{
    public class PostData<TValue>
    {
        public TValue Data { get; set; }
        public string CaptchaCode { get; set; }
    }
}