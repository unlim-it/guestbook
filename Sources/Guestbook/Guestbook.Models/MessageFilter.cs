namespace Guestbook.Models
{
    public class MessageFilter
    {
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public string OrderBy { get; set; }
        public bool OrderByDirection { get; set; }
    }
}